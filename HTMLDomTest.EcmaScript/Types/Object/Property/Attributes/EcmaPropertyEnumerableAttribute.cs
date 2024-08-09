namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public class EcmaPropertyEnumerableAttribute : EcmaPropertyAttribute
{
    public EcmaPropertyEnumerableAttribute(EcmaBoolean? boolean = null)
        : base("Enumerable", boolean ?? EcmaUndefined.Undefined)
    {

    }
}
