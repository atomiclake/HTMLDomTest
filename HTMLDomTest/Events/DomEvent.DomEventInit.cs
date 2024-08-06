using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Events;

public abstract partial class DomEvent
{
    [DomInterface("EventInit")]
    public readonly struct DomEventInit
    {
        [DomName("bubbles")]
        public bool Bubbles { get; }

        [DomName("cancelable")]
        public bool Cancelable { get; }

        [DomName("composed")]
        public bool Composed { get; }
    }
}
