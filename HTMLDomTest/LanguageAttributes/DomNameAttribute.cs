namespace HTMLDomTest.LanguageAttributes;

[AttributeUsage(AttributeTargets.All)]
public class DomNameAttribute : Attribute
{
    public string Name { get; }

    public DomNameAttribute(string name)
    {
        Name = name;
    }
}
