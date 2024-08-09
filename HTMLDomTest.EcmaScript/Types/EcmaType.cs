namespace HTMLDomTest.EcmaScript.Types;

public abstract class EcmaType
{
    public bool IsUndefined => this is EcmaUndefined;
    
    public bool IsNull => this is EcmaNull;
}
