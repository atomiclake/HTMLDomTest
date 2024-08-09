namespace HTMLDomTest.EcmaScript.Types;

public readonly struct EcmaPropertyKey
{
    public string Key { get; }

    public EcmaPropertyKey(string key)
    {
        Key = key;
    }

    public EcmaPropertyKey(EcmaSymbol key)
    {
        Key = key.Name;
    }
}
