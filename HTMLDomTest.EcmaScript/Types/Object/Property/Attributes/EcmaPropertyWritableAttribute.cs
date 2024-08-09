namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public class EcmaPropertyWritableAttribute : EcmaPropertyAttribute
{
    public EcmaPropertyWritableAttribute(EcmaBoolean? boolean = null)
        : base("Writable", boolean ?? EcmaBoolean.False)
    {

    }
}
