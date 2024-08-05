namespace HTMLDomTest.LanguageAttributes;

[AttributeUsage(AttributeTargets.All)]
public class DomObsoleteAttribute : Attribute
{
    public string Message { get; }

    public DomObsoleteAttribute(string message)
    {
        Message = message;
    }

    public DomObsoleteAttribute()
        : this("")
    {

    }
}
