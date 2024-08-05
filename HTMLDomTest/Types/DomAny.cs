using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Types;

[DomInterface("any")]
public class DomAny
{
    public object? Value { get; init; }

    public DomAny(object? value = null)
    {
        Value = value;
    }
}
