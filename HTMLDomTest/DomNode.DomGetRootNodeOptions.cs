using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

public partial class DomNode
{
    public readonly struct DomGetRootNodeOptions
    {
        [DomName("composed")]
        public bool Composed { get; }
    }
}
