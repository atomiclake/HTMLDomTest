namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public class EcmaPropertyGetAttribute : EcmaPropertyAttribute
{
    public EcmaPropertyGetAttribute(EcmaObject? obj = null)
        : base("Get", obj ?? EcmaUndefined.Undefined)
    {

    }
}
