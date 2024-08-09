using HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

namespace HTMLDomTest.EcmaScript.Types;

public class EcmaProperty
{
    private readonly List<EcmaPropertyAttribute> _attributes;

    public EcmaPropertyKey Key { get; }

    public string Name { get; set; }

    public IEnumerable<EcmaPropertyAttribute> Attributes => _attributes.AsEnumerable();

    public EcmaProperty(EcmaPropertyKey key, string name, IEnumerable<EcmaPropertyAttribute> attributes)
    {
        Key = key;
        Name = name;
        _attributes = new(attributes);
    }

    public EcmaProperty(EcmaPropertyKey key, string name)
        : this(key, name, [])
    {

    }
}
