using System.Diagnostics.CodeAnalysis;

namespace HTMLDomTest.EcmaScript.Types.Object.Property.Attributes;

public abstract class EcmaPropertyAttribute : IEqualityComparer<EcmaPropertyAttribute>
{
    public string Name { get; }

    public EcmaAny Value { get; }

    public EcmaPropertyAttribute(string name, EcmaAny value)
    {
        Name = name;
        Value = value;
    }

    public bool Equals(EcmaPropertyAttribute? x, EcmaPropertyAttribute? y)
    {
        return
            x is not null &&
            y is not null &&
            x.Name == y.Name;
    }

    public int GetHashCode([DisallowNull] EcmaPropertyAttribute obj)
    {
        return Name.GetHashCode(StringComparison.OrdinalIgnoreCase);
    }
}
