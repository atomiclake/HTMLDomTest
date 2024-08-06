namespace HTMLDomTest.LanguageAttributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DomImplementedInterfacesAttribute : Attribute
{
    public string[] InterfaceNames { get; }

    public DomImplementedInterfacesAttribute(string[] interfaceNames)
    {
        InterfaceNames = interfaceNames;
    }
}
