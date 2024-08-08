using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Exceptions;

public partial class DomException
{
    public enum ExceptionLegacyType : ushort
    {
        None,

        [DomObsolete("Use RangeError instead")]
        [DomName("INDEX_SIZE_ERR")]
        IndexSizeError = 1,

        [DomName("DOMSTRING_SIZE_ERR")]
        DomStringSizeError = 2,

        [DomName("HIERARCHY_REQUEST_ERR")]
        HierarchyRequestError = 3,

        [DomName("WRONG_DOCUMENT_ERR")]
        WrongDocumentError = 4,

        [DomName("INVALID_CHARACTER_ERR")]
        InvalidCharacterError = 5,

        [DomName("NO_DATA_ALLOWED_ERR")]
        NoDataAllowedError = 6,

        [DomName("NO_MODIFICATION_ALLOWED_ERR")]
        NoModificationAllowedError = 7,

        [DomName("NOT_FOUND_ERR")]
        NotFoundError = 8,

        [DomName("NOT_SUPPORTED_ERR")]
        NotSupportedError = 9,

        [DomName("INUSE_ATTRIBUTE_ERR")]
        InUseAttributeError = 10,

        [DomName("INVALID_STATE_ERR")]
        InvalidStateError = 11,

        [DomName("SYNTAX_ERR")]
        SyntaxError = 12,

        [DomName("INVALID_MODIFICATION_ERR")]
        InvalidModificationError = 13,

        [DomName("NAMESPACE_ERR")]
        NamespaceError = 14,

        [DomObsolete("Use TypeError, NotSupportedError (DOM) or NotAllowedError (DOM) instead where appropriate")]
        [DomName("INVALID_ACCESS_ERR")]
        InvalidAccessError = 15,

        [DomName("VALIDATION_ERR")]
        ValidationError = 16,

        [DomObsolete("Use TypeError instead")]
        [DomName("TYPE_MISMATCH_ERR")]
        TypeMismatchError = 17,

        [DomName("SECURITY_ERR")]
        SecurityError = 18,

        [DomName("NETWORK_ERR")]
        NetworkError = 19,

        [DomName("ABORT_ERR")]
        AbortError = 20,

        [DomObsolete]
        [DomName("URL_MISMATCH_ERR")]
        UrlMismatchError = 21,

        [DomName("QUOTA_EXCEEDED_ERR")]
        QuotaExceededError = 22,

        [DomName("TIMEOUT_ERR")]
        TimeoutError = 23,

        [DomName("INVALID_NODE_TYPE_ERR")]
        InvalidNodeTypeError = 24,

        [DomName("DATA_CLONE_ERR")]
        DataCloneError = 25
    }
}
