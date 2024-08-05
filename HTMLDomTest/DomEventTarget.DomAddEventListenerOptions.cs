using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

public partial class DomEventTarget
{
    [DomInterface("AddEventListenerOptions")]
    public class DomAddEventListenerOptions : DomEventListenerOptions
    {
        [DomName("once")]
        public bool? Once { get; init; }

        [DomName("passive")]
        public bool? Passive { get; init; }

        [DomName("signal")]
        public DomAbortSignal AbortSignal { get; init; }
    }
}
