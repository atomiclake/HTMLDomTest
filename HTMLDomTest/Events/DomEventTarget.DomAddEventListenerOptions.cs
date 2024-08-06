using HTMLDomTest.Events.DomEvents;
using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Events;

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
        public DomAbortSignal? Signal { get; init; }
    }
}
