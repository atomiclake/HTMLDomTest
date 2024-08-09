using HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

namespace HTMLDomTest.EcmaScript.Types.Object.Property;

public class EcmaObjectPropertyAttributesBuilder
{
    private List<EcmaPropertyAttribute> _attributes;

    private EcmaAny? _value;

    private EcmaBoolean? _writable;

    private EcmaObject? _get;

    private EcmaObject? _set;

    private EcmaBoolean? _enumerable;

    private EcmaBoolean? _configurable;

    public EcmaObjectPropertyAttributesBuilder()
    {
        _attributes = [];
    }

    public EcmaObjectPropertyAttributesBuilder Value(EcmaAny? value = null)
    {
        _value = value;
        return this;
    }

    public EcmaObjectPropertyAttributesBuilder Writable(EcmaBoolean? writable = null)
    {
        _writable = writable;
        return this;
    }

    public EcmaObjectPropertyAttributesBuilder Get(EcmaObject? get = null)
    {
        _get = get;
        return this;
    }

    public EcmaObjectPropertyAttributesBuilder Set(EcmaObject? set = null)
    {
        _set = set;
        return this;
    }

    public EcmaObjectPropertyAttributesBuilder Enumerable(EcmaBoolean? enumerable = null)
    {
        _enumerable = enumerable;
        return this;
    }

    public EcmaObjectPropertyAttributesBuilder Configurable(EcmaBoolean? configurable = null)
    {
        _configurable = configurable;
        return this;
    }

    public List<EcmaPropertyAttribute> Build(bool assignDefaultToNulls = true)
    {
        if (assignDefaultToNulls || _value is not null)
        {
            _attributes.Add(new EcmaPropertyValueAttribute(_value));
        }

        if (assignDefaultToNulls || _writable is not null)
        {
            _attributes.Add(new EcmaPropertyWritableAttribute(_writable));
        }

        if (assignDefaultToNulls || _get is not null)
        {
            _attributes.Add(new EcmaPropertyGetAttribute(_get));
        }

        if (assignDefaultToNulls || _set is not null)
        {
            _attributes.Add(new EcmaPropertySetAttribute(_set));
        }

        if (assignDefaultToNulls || _enumerable is not null)
        {
            _attributes.Add(new EcmaPropertyEnumerableAttribute(_enumerable));
        }

        if (assignDefaultToNulls || _configurable is not null)
        {
            _attributes.Add(new EcmaPropertyValueAttribute(_configurable));
        }

        return _attributes;
    }
}
