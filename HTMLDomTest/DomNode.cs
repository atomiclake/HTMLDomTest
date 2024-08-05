using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

[DomInterface("Node")]
public partial class DomNode
{
    [DomName("baseURI")]
    public string BaseUri { get; init; }

    [DomName("childNodes")]
    public IEnumerable<DomNode> ChildNodes { get; init; }

    [DomName("firstChild")]
    public DomNode? FirstChild { get; init; }

    [DomName("isConnected")]
    public bool IsConnected { get; init; }

    [DomName("lastChild")]
    public DomNode? LastChild { get; init; }

    [DomName("nextSibling")]
    public DomNode? NextSibling { get; init; }

    [DomName("nodeName")]
    public string NodeName { get; init; }

    [DomName("nodeType")]
    public DomNodeType NodeType { get; init; }

    [DomName("nodeValue")]
    public string? NodeValue { get; init; }

    [DomName("ownerDocument")]
    public DomDocument? OwnerDocument { get; init; }

    [DomName("parentElement")]
    public DomElement? ParentElement { get; init; }

    [DomName("parentNode")]
    public DomNode? ParentNode { get; init; }

    [DomName("previousSibling")]
    public DomNode? PreviousSibling { get; init; }

    [DomName("textContent")]
    public string? TextContent { get; init; }

    [DomName("appendChild")]
    public DomNode AppendChild(
        [DomName("node")] DomNode node)
    {
        throw new NotImplementedException();
    }

    [DomName("cloneNode")]
    public DomNode CloneNode(
        [DomName("deep")] bool deep = false)
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

    [DomName("getRootNode")]
    public DomNode GetRootNode(
        [DomName("options")] DomGetRootNodeOptions? options = null)
    {
        throw new NotImplementedException();
    }

    [DomName("hasChildNodes")]
    public bool HasChildNodes()
    {
        throw new NotImplementedException();
    }

    [DomName("insertBefore")]
    public bool InsertBefore(
        [DomName("node")] DomNode node,
        [DomName("child")] DomNode? child)
    {
        throw new NotImplementedException();
    }

    [DomName("isDefaultNamespace")]
    public bool IsDefaultNamespace(
        [DomName("namespace")] string? namespaceUri)
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

    [DomName("lookupNamespaceURI")]
    public string? LookupNamespaceUri(
        [DomName("prefix")] string? prefix)
    {
        throw new NotImplementedException();
    }

    [DomName("lookupPrefix")]
    public string? LookupPrefix(
        [DomName("namespace")] string? namespaceUri)
    {
        throw new NotImplementedException();
    }

    [DomName("normalize")]
    public void Normalize()
    {
        throw new NotImplementedException();
    }

    [DomName("removeChild")]
    public bool RemoveChild(
        [DomName("node")] DomNode node)
    {
        throw new NotImplementedException();
    }

    [DomName("replaceChild")]
    public bool ReplaceChild(
        [DomName("node")] DomNode node,
        [DomName("child")] DomNode child)
    {
        throw new NotImplementedException();
    }
}
