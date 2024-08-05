using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

public partial class DomNode
{
    public enum DomDocumentPosition : ushort
    {
        [DomName("DOCUMENT_POSITION_DISCONNECTED")]
        Disconnected = 0x01,

        [DomName("DOCUMENT_POSITION_PRECEDING")]
        Preceding = 0x2,

        [DomName("DOCUMENT_POSITION_FOLLOWING")]
        Following = 0x4,

        [DomName("DOCUMENT_POSITION_CONTAINS")]
        Contains = 0x8,

        [DomName("DOCUMENT_POSITION_CONTAINED_BY")]
        ContainedBy = 0x10,

        [DomName("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC")]
        ImplementationSpecific = 0x20
    }
}
