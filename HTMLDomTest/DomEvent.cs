using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

[DomInterface("Event")]
public partial class DomEvent
{
    [DomName("bubbles")]
    public bool Bubbles { get; init; }

    [DomName("cancelable")]
    public bool Cancelable { get; init; }

    [DomName("cancelBubble")]
    [DomObsolete("Use Event.stopPropagation() instead")]
    public bool CancelBubble { get; init; }

    [DomName("composed")]
    public bool Composed { get; init; }

    [DomName("currentTarget")]
    public DomEvent CurrentTarget { get; init; }

    [DomName("defaultPrevented")]
    public bool DefaultPrevented { get; init; }

    [DomName("eventPhase")]
    public DomEventPhase EventPhase { get; init; }

    [DomName("isTrusted")]
    public bool IsTrusted { get; init; }

    [DomName("returnValue")]
    [DomObsolete("Use preventDefault() and defaultPrevented instead")]
    public bool ReturnValue { get; init; }

    [DomName("srcElement")]
    [DomObsolete("Use Event.target instead")]
    public DomEventTarget SrcElement { get; init; }

    [DomName("target")]
    public DomEventTarget Target { get; init; }

    [DomName("timeStamp")]
    public int Timestamp { get; init; }

    [DomName("type")]
    public string Type { get; init; }

    public DomEvent()
    {
        throw new NotImplementedException();
    }

    [DomName("composedPath")]
    public DomEventTarget[] ComposedPath()
    {
        throw new NotImplementedException();
    }

    [DomName("initEvent")]
    [DomObsolete("Use the constructor instead")]
    public void InitEvent(
        [DomName("type")] string type,
        [DomName("bubbles")] bool bubbles,
        [DomName("cancelable")] bool cancelable)
    {
        throw new NotImplementedException();
    }

    [DomName("preventDefault")]
    public void PreventDefault()
    {
        throw new NotImplementedException();
    }

    [DomName("stopImmediatePropagation")]
    public void StopImmediatePropagation()
    {
        throw new NotImplementedException();
    }

    [DomName("stopPropagation")]
    public void StopPropagation()
    {
        throw new NotImplementedException();
    }
}
