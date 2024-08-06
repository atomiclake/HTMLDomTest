namespace HTMLDomTest.Events;

public abstract partial class DomEvent
{
    public enum DomEventPhase : ushort
    {
        None,
        Capturing,
        AtTarget,
        Bubbling
    }
}
