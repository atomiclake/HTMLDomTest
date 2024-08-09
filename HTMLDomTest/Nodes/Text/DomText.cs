using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Nodes.CharacterData;

namespace HTMLDomTest.Nodes.Text;

[DomInterface("DomText")]
[DomImplementedInterfaces([nameof(DomCharacterData)])]
public class DomText : DomCharacterData
{
    public string WholeText { get; }

    public DomText(string data)
    {
        WholeText = data;
    }

    public DomText SplitText(uint offset)
    {

    }
}

[DomInterface("CDATASection")]
public class DomCDataSection : DomText
{
    public DomCDataSection(string data)
        : base(data)
    {
        
    }
}
