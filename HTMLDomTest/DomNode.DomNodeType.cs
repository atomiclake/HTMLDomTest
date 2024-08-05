using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

public partial class DomNode
{
    public enum DomNodeType : ushort
    {
        [DomName("ELEMENT_NODE")]
        Element = 1,

        [DomName("ATTRIBUTE_NODE")]
        Attribute = 2,

        [DomName("TEXT_NODE")]
        Text = 3,

        [DomName("CDATA_SECTION_NODE")]
        CDataSection = 4,

        [DomObsolete]
        [DomName("ENTITY_REFERENCE_NODE")]
        EntityReference = 5,

        [DomObsolete]
        [DomName("ENTITY_NODE")]
        Entity = 6,

        [DomName("PROCESSING_INSTRUCTION_NODE")]
        ProcessingInstruction = 7,

        [DomName("COMMENT_NODE")]
        Comment = 8,

        [DomName("DOCUMENT_NODE")]
        Document = 9,

        [DomName("DOCUMENT_TYPE_NODE")]
        DocumentType = 10,

        [DomName("DOCUMENT_FRAGMENT_NODE")]
        DocumentFragment = 11,

        [DomObsolete]
        [DomName("NOTATION_NODE")]
        Notation = 12
    }
}
