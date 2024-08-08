using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Nodes.Documents;

[DomInterface("DocumentType")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomDocumentType : DomNode
{
    public string Name { get; } = default!;

    public string PublicId { get; } = default!;

    public string SystemId { get; } = default!;
}
