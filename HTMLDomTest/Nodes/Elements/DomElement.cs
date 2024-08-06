using HTMLDomTest.Events;
using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Nodes.Elements;

[DomInterface("Element")]
[DomImplementedInterfaces([nameof(DomNode)])]
public class DomElement : DomNode
{

}
