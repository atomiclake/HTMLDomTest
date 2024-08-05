using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

[DomInterface("EventTarget")]
public partial class DomEventTarget
{
    public DomEventTarget()
    {
        throw new NotImplementedException();
    }

    public void AddEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("options")] DomAddEventListenerOptions options)
    {
        throw new NotImplementedException();
    }

    public void AddEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("useCapture")] bool useCapture)
    {
        throw new NotImplementedException();
    }

    public void RemoveEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("options")] DomEventListenerOptions options)
    {
        throw new NotImplementedException();
    }

    public void RemoveEventListener(
        [DomName("type")] string type,
        [DomName("listener")] DomEventListener? listener,
        [DomName("useCapture")] bool useCapture)
    {
        throw new NotImplementedException();
    }

    public bool DispatchEvent(
        [DomName("event")] DomEvent domEvent)
    {
        throw new NotImplementedException();
    }
}
