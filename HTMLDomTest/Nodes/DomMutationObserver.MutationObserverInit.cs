namespace HTMLDomTest.Nodes.Documents;

public partial class DomMutationObserver
{
    public struct MutationObserverInit
    {
        public bool ChildList { get; set; }

        public bool Attributes { get; set; }

        public bool CharacterData { get; set; }

        public bool Subtree { get; set; }

        public bool AttributeOldValue { get; set; }

        public bool CharacterDataOldValue { get; set; }

        public IEnumerable<string> AttributeFilter { get; set; }
    }
}
