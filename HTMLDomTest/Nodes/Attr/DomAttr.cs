using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Nodes.Elements;

namespace HTMLDomTest.Nodes.Attr;

[DomInterface("Attr")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomAttr : DomNode
{
    public string? NamespaceUri { get; }

    public string? Prefix { get; }

    public string LocalName { get; } = default!;

    public string Name { get; } = default!;

    public string Value { get; } = "";

    public DomElement? OwnerElement { get; }

    public readonly bool Specified = true;

    public bool IsA => LocalName == "A" && NamespaceUri is null && Prefix is null;

    public string QualifiedName => $"{$"{NamespaceUri}:" ?? ""}{LocalName}";

    internal DomAttr(string localName, string name, string value, DomElement? ownerElement, string? namespaceUri, string? prefix)
    {
        NamespaceUri = namespaceUri;
        Prefix = prefix;
        LocalName = localName;
        Name = name;
        Value = value;
        OwnerElement = ownerElement;
        Prefix = prefix;
    }

    internal DomAttr(string localName, string name, string value)
        : this(localName, name, value, null, null, null)
    {

    }
}
