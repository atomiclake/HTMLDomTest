namespace HTMLDomTest.EcmaScript.Types;

public class EcmaBoolean : EcmaUndefined
{
    private bool _value;

    public static readonly EcmaBoolean True = new(true);

    public static readonly EcmaBoolean False = new(false);

    private EcmaBoolean(bool value)
    {
        _value = value;
    }
}
