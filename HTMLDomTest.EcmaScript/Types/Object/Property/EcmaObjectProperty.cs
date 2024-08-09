using HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

namespace HTMLDomTest.EcmaScript.Types.Object.Property;

public class EcmaObjectProperty : EcmaProperty
{
    protected EcmaObjectProperty(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes)
        : base(key, name, attributes)
    {

    }

    protected static TObjectProperty Build<TObjectProperty>(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes,
        IEnumerable<EcmaPropertyAttribute> defaultAttributes)
        where TObjectProperty : EcmaObjectProperty
    {
        var setDefaultAttributes = attributes.Intersect(defaultAttributes);

        var actualAttributes = setDefaultAttributes.Union(attributes);

        return (TObjectProperty)new EcmaObjectProperty(key, name, actualAttributes);
    }
}
