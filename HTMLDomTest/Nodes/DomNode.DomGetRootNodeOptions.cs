using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

public abstract partial class DomNode
{
    public readonly struct DomGetRootNodeOptions
    {
        [DomName("composed")]
        public bool Composed { get; }
    }
}
