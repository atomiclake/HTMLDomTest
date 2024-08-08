using HTMLDomTest.Events;
using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Nodes.Documents;
using HTMLDomTest.Nodes.Elements;
using HTMLDomTest.Types;

namespace HTMLDomTest;

[DomInterface("Node")]
[DomImplementedInterfaces([nameof(DomEventTarget)])]
public abstract partial class DomNode : DomEventTarget, IDomTree<DomNode>
{
    internal DomNode? _root;

    internal DomNode? _parent;

    internal DomElement? _parentElement;

    private readonly List<DomNode> _children = [];

    internal DomDocument? _nodeDocument;

    [DomName("nodeType")]
    public DomNodeType NodeType { get; }

    [DomName("nodeName")]
    public string NodeName { get; } = default!;

    [DomName("baseURI")]
    public string BaseUri { get; } = default!;

    [DomName("nodeValue")]
    public string? NodeValue => throw new NotImplementedException();

    [DomName("isConnected")]
    public bool IsConnected => throw new NotImplementedException();

    [DomName("ownerDocument")]
    public DomDocument? OwnerDocument => this is DomDocument ? null : _nodeDocument;

    [DomName("parentNode")]
    public DomNode? Parent => _parent;

    [DomName("parentElement")]
    public DomElement? ParentElement => _parentElement;

    [DomName("childNodes")]
    public IEnumerable<DomNode> Children => _children.AsEnumerable();

    [DomName("firstChild")]
    public DomNode? FirstChild => _children.FirstOrDefault();

    [DomName("lastChild")]
    public DomNode? LastChild => _children.LastOrDefault();

    [DomName("previousSibling")]
    public DomNode? PreviousSibling => GetPreviousSibling();

    [DomName("nextSibling")]
    public DomNode? NextSibling => GetNextSibling();

    [DomName("textContent")]
    public string? TextContent => throw new NotImplementedException();

    public DomDocument NodeDocument => this is DomDocument document ? document : _nodeDocument!;

    public DomNode? Root => _root;

    public int Length => throw new NotImplementedException();

    public int Index => _parent is null ? 0 : _parent._children.IndexOf(this);

    private DomNode? GetPreviousSibling()
    {
        if (_parent is null || _parent._children.Count < 1)
        {
            return null;
        }

        int index = _parent._children.IndexOf(this);

        return index is < 0 ?
            null :
            _parent._children[index - 1];
    }

    private DomNode? GetNextSibling()
    {
        if (_parent is null || _parent._children.Count < 1)
        {
            return null;
        }

        int index = _parent._children.IndexOf(this);

        return index == _parent._children.Count - 1 || index == -1 ?
            null :
            _parent._children[index + 1];
    }

    [DomName("getRootNode")]
    public DomNode GetRootNode(
        [DomName("options")] DomGetRootNodeOptions? options = null)
    {
        if (options is not null and DomGetRootNodeOptions o && o.Composed)
        {
            // get shadow including root
            throw new NotImplementedException();
        }

        // TODO: Apparently nodes are supposed to always have a root, check this
        return _root!;
    }

    [DomName("hasChildNodes")]
    public bool HasChildNodes()
    {
        return _children.Count != 0;
    }

    [DomName("normalize")]
    public void Normalize()
    {
        throw new NotImplementedException();
    }

    [DomName("cloneNode")]
    public DomNode CloneNode(
        [DomName("deep")] bool deep = false)
    {
        throw new NotImplementedException();
    }

    [DomName("isEqualNode")]
    public bool IsEqualNode(
        [DomName("otherNode")] DomNode? other)
    {
        throw new NotImplementedException();
    }

    [DomName("isSameNode")]
    public bool IsSameNode(
        [DomName("otherNode")] DomNode? other)
    {
        throw new NotImplementedException();
    }

    [DomName("compareDocumentPosition")]
    public DomDocumentPosition CompareDocumentPosition(
        [DomName("other")] DomNode other)
    {
        throw new NotImplementedException();
    }

    [DomName("contains")]
    public bool Contains(
        [DomName("other")] DomNode? other)
    {
        throw new NotImplementedException();
    }

    [DomName("lookupPrefix")]
    public string? LookupPrefix(
       [DomName("namespace")] string? namespaceUri)
    {
        throw new NotImplementedException();
    }

    [DomName("lookupNamespaceURI")]
    public string? LookupNamespaceUri(
        [DomName("prefix")] string? prefix)
    {
        throw new NotImplementedException();
    }

    [DomName("isDefaultNamespace")]
    public bool IsDefaultNamespace(
         [DomName("namespace")] string? namespaceUri)
    {
        throw new NotImplementedException();
    }

    private void EnsurePreInsertionValidity(DomNode node, DomNode? child)
    {
        if (_parent is not DomDocument or DomDocumentFragment or DomElement)
        {
            // TODO: Throw HierarchyRequestError
            throw new NotImplementedException();
        }

        // TODO: Add host including inclusive ancestor check

        if (child is not null && child.Parent != _parent)
        {
            // TODO: Throw NotFoundError
            throw new NotImplementedException();
        }

        if (node is not DomDocumentFragment or DomDocumentType or DomElement or DomCharacterData)
        {
            // TODO: Throw HierarchyRequestError
            throw new NotImplementedException();
        }

        if ((node is DomText && node.Parent is DomDocument) || (node is DomDocumentType && node.Parent is not DomDocument))
        {
            // TODO: Throw HierarchyRequestError
            throw new NotImplementedException();
        }

        if (_parent is DomDocument)
        {
            // TODO: Add the necessary checks
            // TODO: Throw HierarchyRequestError
            throw new NotImplementedException();
        }
    }

    [DomName("insertBefore")]
    public DomNode InsertBefore(
        [DomName("node")] DomNode node,
        [DomName("child")] DomNode? child)
    {
        EnsurePreInsertionValidity(node, child);

        // TODO: Check whether this function will insert before the child
        _parent!._children.Insert(node.Index, child!);

        return node;
    }

    [DomName("appendChild")]
    public DomNode AppendChild(
        [DomName("node")] DomNode node)
    {
        if (_parent is not null && _parent.FirstChild is not null)
        {
            InsertBefore(_parent.FirstChild, node);
        }

        return node;
    }

    [DomName("replaceChild")]
    public bool ReplaceChild(
        [DomName("node")] DomNode node,
        [DomName("child")] DomNode child)
    {
        throw new NotImplementedException();
    }

    [DomName("removeChild")]
    public bool RemoveChild(
        [DomName("node")] DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsDescendant(DomNode node)
    {
        if (_parent is null)
        {
            return false;
        }

        Queue<DomNode> nodes = new(node._children);

        while (nodes.Count > 0)
        {
            DomNode current = nodes.Dequeue();

            if (current == node)
            {
                return true;
            }

            current._children.ForEach(nodes.Enqueue);
        }

        return false;
    }

    public bool IsInclusiveDescendant(DomNode node)
    {
        return this == node || IsDescendant(node);
    }

    public bool IsAncestor(DomNode node)
    {
        if (_children.Contains(node))
        {
            return true;
        }

        DomNode? parent = node._parent;

        while (parent is not null)
        {
            if (parent._children.Contains(node))
            {
                return true;
            }

            parent = parent._parent;
        }

        return false;
    }

    public bool IsInclusiveAncestor(DomNode node)
    {
        return this == node || IsAncestor(node);
    }

    public bool IsSibling(DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsInclusiveSibling(DomNode node)
    {
        return this == node || IsSibling(node);
    }

    public bool IsPreceding(DomNode node)
    {

    }

    public bool IsFollowing(DomNode node)
    {
        throw new NotImplementedException();
    }
}
