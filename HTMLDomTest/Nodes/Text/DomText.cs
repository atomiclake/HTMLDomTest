using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Nodes.CharacterData;

namespace HTMLDomTest.Nodes.Text;

[DomInterface("DomText")]
[DomImplementedInterfaces([nameof(DomCharacterData)])]
public class DomText : DomCharacterData
{

}
