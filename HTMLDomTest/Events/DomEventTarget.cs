using HTMLDomTest.Events.DomEvents;
using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Nodes.Elements;
using HTMLDomTest.Nodes.Window;

namespace HTMLDomTest.Events;

// https://dom.spec.whatwg.org/#dom-eventtarget-eventtarget
[DomInterface("EventTarget")]
public partial class DomEventTarget
{
    private static readonly string[] _eventTargetsWithDefaultPassiveValue = ["touchstart", "touchmove", "wheel", "mousewheel"];

    private readonly List<DomEventListener> _listeners;

    public DomEventTarget()
    {
        _listeners = [];
    }

    // https://dom.spec.whatwg.org/#add-an-event-listener
    public void AddEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("options")] DomAddEventListenerOptions options)
    {
        bool capture = options.Capture;
        bool? once = options.Once;
        bool? passive = options.Passive ??
            _eventTargetsWithDefaultPassiveValue.Contains(type) ||
            this is DomWindow ||
            (this is DomNode node && node.OwnerDocument is not null) || // TODO: Check if this behavior is correct
            (this is DomElement element && element.OwnerDocument is not null) || // TODO: Check if this behavior is correct
            (this is DomElement maybeBody && maybeBody.NodeName is "body" or "frameset"); // FIXME: Use the actual element class once you build them

        DomAbortSignal? signal = options.Signal;

        if (signal is not null && signal.Aborted)
        {
            return;
        }

        if (listener is null)
        {
            return;
        }

        // TODO: Add support for the service worker checks

        if (!_listeners.Any(l => l.Type == type || l.Callback == listener.Callback || l.Capture == capture))
        {
            _listeners.Add(listener);
        }

        if (listener.Signal is not null)
        {
            RemoveEventListener(type, listener, capture);
        }
    }

    // https://dom.spec.whatwg.org/#add-an-event-listener
    public void AddEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("useCapture")] bool useCapture)
    {
        AddEventListener(type, listener, new DomAddEventListenerOptions() { Capture = useCapture });
    }

    // https://dom.spec.whatwg.org/#remove-an-event-listener
    public void RemoveEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("options")] DomEventListenerOptions options)
    {
        if (listener is null)
        {
            return;
        }

        // TODO: Add support for the service worker checks

        DomEventListener? l = _listeners.FirstOrDefault(x => x == listener, null);

        if (l is not null)
        {
            l.Removed = true;
            _listeners.Remove(l);
        }
    }

    public void RemoveEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("useCapture")] bool useCapture)
    {
        RemoveEventListener(type, listener, new DomAddEventListenerOptions() { Capture = useCapture });
    }

    public bool DispatchEvent(
        [DomName("event")] DomEvent domEvent)
    {
        throw new NotImplementedException();
    }
}
