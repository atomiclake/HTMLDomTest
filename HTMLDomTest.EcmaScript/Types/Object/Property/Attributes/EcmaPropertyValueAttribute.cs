namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public class EcmaPropertyValueAttribute : EcmaPropertyAttribute
{
    public EcmaPropertyValueAttribute(EcmaAny? type)
        : base("Value", type ?? EcmaUndefined.Undefined)
    {

    }
}
