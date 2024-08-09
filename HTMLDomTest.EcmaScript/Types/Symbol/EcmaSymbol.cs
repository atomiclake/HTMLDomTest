namespace HTMLDomTest.EcmaScript.Types;

public partial class EcmaSymbol : EcmaAny
{
    public string Name { get; }

    public EcmaSymbol(string name)
    {
        Name = name;
    }
}
