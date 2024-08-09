namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public class EcmaPropertyConfigurableAttribute : EcmaPropertyAttribute
{
    public EcmaPropertyConfigurableAttribute(EcmaBoolean? boolean = null)
        : base("Configurable", boolean ?? EcmaUndefined.Undefined)
    {

    }
}
