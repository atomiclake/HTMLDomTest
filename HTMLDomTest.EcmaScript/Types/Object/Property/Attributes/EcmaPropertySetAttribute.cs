namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public class EcmaPropertySetAttribute : EcmaPropertyAttribute
{
    public EcmaPropertySetAttribute(EcmaObject? obj = null)
        : base("Set", obj ?? EcmaUndefined.Undefined)
    {

    }
}
