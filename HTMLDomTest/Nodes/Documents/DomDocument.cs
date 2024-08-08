using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Nodes.Documents;

[DomInterface("Document")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomDocument : DomNode
{

}
