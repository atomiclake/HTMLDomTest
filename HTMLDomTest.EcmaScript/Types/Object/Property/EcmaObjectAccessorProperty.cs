using HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

namespace HTMLDomTest.EcmaScript.Types.Object.Property;

public class EcmaObjectAccessorProperty : EcmaObjectProperty
{
    protected EcmaObjectAccessorProperty(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes)
        : base(key, name, attributes)
    {

    }

    public static EcmaObjectAccessorProperty Build(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes)
    {
        List<EcmaPropertyAttribute> defaultAccessorPropertyAttributes = new EcmaObjectPropertyAttributesBuilder()
            .Get()
            .Set()
            .Enumerable()
            .Configurable()
            .Build();

        return Build<EcmaObjectAccessorProperty>(key, name, attributes, defaultAccessorPropertyAttributes);
    }
}
