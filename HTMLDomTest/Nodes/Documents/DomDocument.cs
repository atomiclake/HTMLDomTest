using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Nodes.Documents;

[DomInterface("Document")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomDocument : DomNode
{

}

[DomInterface("DocumentType")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomDocumentType : DomNode
{
    public string Name { get; } = default!;

    public string PublicId { get; } = default!;

    public string SystemId { get; } = default!;
}

[DomInterface("CharacterData")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomCharacterData : DomNode
{

}

[DomInterface("DomText")]
[DomImplementedInterfaces([nameof(DomCharacterData)])]
public class DomText : DomCharacterData
{
    
}
