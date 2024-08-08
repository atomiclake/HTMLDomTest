using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Nodes.CharacterData;

[DomInterface("CharacterData")]
[DomImplementedInterfaces([nameof(DomNode)])]
public abstract class DomCharacterData : DomNode
{
    // NOTE: Data values should be stringfied
    public string Data { get; } = "";

    public uint Length { get; }

    public string SubstringData(uint offset, uint count)
    {
        if (offset > Length)
        {
            // throw IndexSizeError
            throw new NotImplementedException();
        }

        if (offset + count > Length)
        {
            return Data[(int)offset..];
        }

        int minOffset = (int)offset;
        int maxOffset = (int)(offset + count > Length ? Length : offset + count);

        return Data[minOffset..maxOffset];
    }

    public void ReplaceData(uint offset, uint count, string data)
    {
        if (offset > Length)
        {
            // throw IndexSizeError
            throw new NotImplementedException();
        }

        uint actualCount = offset + count > Length ? Length - offset : count;

        // TODO: Queue a mutation record


    }
}
