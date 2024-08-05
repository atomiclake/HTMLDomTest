namespace HTMLDomTest.LanguageAttributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DomInterfaceAttribute : Attribute
{
    public string Name { get; }

    public DomInterfaceAttribute(string name)
    {
        Name = name;
    }
}
