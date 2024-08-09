using HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

namespace HTMLDomTest.EcmaScript.Types.Object.Property;

public class EcmaObjectDataProperty : EcmaObjectProperty
{
    protected EcmaObjectDataProperty(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes)
        : base(key, name, attributes)
    {

    }

    public static EcmaObjectDataProperty Build(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes)
    {
        List<EcmaPropertyAttribute> defaultDataPropertyAttributes = new EcmaObjectPropertyAttributesBuilder()
            .Value()
            .Writable()
            .Enumerable()
            .Configurable()
            .Build();

        return Build<EcmaObjectDataProperty>(key, name, attributes, defaultDataPropertyAttributes);
    }
}
