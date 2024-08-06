using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Events;

public partial class DomEventTarget
{
    [DomInterface("AddEventListenerOptions")]
    public class DomEventListenerOptions
    {
        [DomName("capture")]
        public bool Capture { get; init; }
    }
}
