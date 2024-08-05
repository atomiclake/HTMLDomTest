using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

public partial class DomEventTarget
{
    [DomInterface("AddEventListenerOptions")]
    public class DomEventListenerOptions
    {
        [DomName("capture")]
        public bool? Capture { get; init; }
    }
}
