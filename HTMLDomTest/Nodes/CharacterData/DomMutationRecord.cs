using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Nodes.CharacterData;

[DomInterface("MutationRecord")]
public class DomMutationRecord
{
    public string Type { get; }

    public DomNode Target { get; }

    public IEnumerable<DomNode> AddedNodes { get; }

    public IEnumerable<DomNode> RemovedNodes { get; }

    public DomNode? PreviousSibling { get; }

    public DomNode? NextSibling { get; }

    public string? AttributeName { get; }

    public string? AttributeNamespace { get; }

    public string? OldValue { get; }

    internal DomMutationRecord(string type, DomNode target, IEnumerable<DomNode> addedNodes, IEnumerable<DomNode> removedNodes,
        DomNode? previousSibling = null, DomNode? nextSibling = null, string? attributeName = null, string? attributeNamespace = null,
        string? oldValue = null)
    {
        Type = type;
        Target = target;
        AddedNodes = addedNodes;
        RemovedNodes = removedNodes;
        PreviousSibling = previousSibling;
        NextSibling = nextSibling;
        AttributeName = attributeName;
        AttributeNamespace = attributeNamespace;
        OldValue = oldValue;
    }

    internal DomMutationRecord(string type, DomNode target, IEnumerable<DomNode> addedNodes, IEnumerable<DomNode> removedNodes)
        : this(type, target, addedNodes, removedNodes, null, null, null, null, null)
    {

    }

    internal DomMutationRecord(string type, DomNode target)
        : this(type, target, [], [], null, null, null, null, null)
    {

    }
}
