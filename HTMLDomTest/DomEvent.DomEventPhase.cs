namespace HTMLDomTest;

public partial class DomEvent
{
    public enum DomEventPhase : ushort
    {
        None,
        Capturing,
        AtTarget,
        Bubbling
    }
}
