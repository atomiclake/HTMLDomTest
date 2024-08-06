using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Events;

// TODO: Implement dispatch once shadow root is finished
[DomInterface("Event")]
public abstract partial class DomEvent
{
    internal bool _stopPropagationFlag;
    internal bool _stopImmediatePropagationFlag;
    internal bool _canceledFlag;
    internal bool _inPassiveListenerFlag;
    internal bool _composedFlag;
    internal bool _initializedFlag;
    internal bool _dispatchedFlag;
    internal bool _isTrustedFlag;

    internal bool _bubbles;
    internal bool _cancelable;

    [DomName("bubbles")]
    public bool Bubbles => _bubbles;

    [DomName("cancelable")]
    public bool Cancelable => _cancelable;

    [DomName("cancelBubble")]
    [DomObsolete("Use Event.stopPropagation() instead")]
    public bool CancelBubble
    {
        get => _stopPropagationFlag;

        set
        {
            // TODO: Check if this is actually necessary in C#
            if (value)
            {
                _stopPropagationFlag = true;
            }
        }
    }

    [DomName("composed")]
    public bool Composed => _composedFlag;

    [DomName("currentTarget")]
    public DomEvent? CurrentTarget { get; internal set; }

    [DomName("defaultPrevented")]
    public bool DefaultPrevented => _canceledFlag;

    [DomName("eventPhase")]
    public DomEventPhase EventPhase { get; internal set; }

    [DomName("isTrusted")]
    public bool IsTrusted { get; internal set; }

    [DomName("returnValue")]
    [DomObsolete("Use preventDefault() and defaultPrevented instead")]
    public bool ReturnValue => _canceledFlag;

    [DomName("srcElement")]
    [DomObsolete("Use Event.target instead")]
    public DomEventTarget? SrcElement { get; internal set; }

    [DomName("target")]
    public DomEventTarget? Target { get; internal set; }

    [DomName("timeStamp")]
    public int Timestamp { get; internal set; }

    [DomName("type")]
    public string Type { get; internal set; } = default!;

    public DomEvent()
    {

    }

    // https://dom.spec.whatwg.org/#dom-event-event
    public DomEvent(string type)
    {
        Type = type;
    }

    // https://dom.spec.whatwg.org/#dom-event-event
    public DomEvent(string type, DomEventInit eventInit)
        : this(type)
    {
        _bubbles = eventInit.Bubbles;
        _cancelable = eventInit.Cancelable;
        _composedFlag = eventInit.Composed;
    }

    [DomName("composedPath")]
    public DomEventTarget[] ComposedPath()
    {
        throw new NotImplementedException();
    }

    // https://dom.spec.whatwg.org/#concept-event-initialize
    [DomName("initEvent")]
    [DomObsolete("Use the constructor instead")]
    public void InitEvent(
        [DomName("type")] string type,
        [DomName("bubbles")] bool bubbles,
        [DomName("cancelable")] bool cancelable)
    {
        // 1.
        _initializedFlag = true;

        // 2.
        _stopPropagationFlag = false;
        _stopImmediatePropagationFlag = false;
        _canceledFlag = false;

        // 3.
        _isTrustedFlag = false;

        // 4.
        Target = null;

        // 5.
        Type = type;

        // 6.
        _bubbles = bubbles;

        // 7.
        _cancelable = cancelable;
    }

    public void PreventDefault()
    {
        // https://dom.spec.whatwg.org/#set-the-canceled-flag
        if (Cancelable && !_inPassiveListenerFlag)
        {
            _canceledFlag = true;
        }
    }

    [DomName("stopImmediatePropagation")]
    public void StopImmediatePropagation()
    {
        StopPropagation();
        _stopImmediatePropagationFlag = true;
    }

    [DomName("stopPropagation")]
    public void StopPropagation()
    {
        _stopPropagationFlag = true;
    }
}
