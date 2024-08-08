using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest.Exceptions;

[DomInterface("DOMException")]
public partial class DomException : IDomExceptionBuilder<DomException>
{
    private static readonly string[] EXCEPTION_NAMES_TABLE = [
        "IndexSizeError",
        "HierarchyRequestError",
        "WrongDocumentError",
        "InvalidCharacterError",
        "NoModificationAllowedError",
        "NotFoundError",
        "NotSupportedError",
        "InUseAttributeError",
        "InvalidStateError",
        "SyntaxError",
        "InvalidModificationError",
        "NamespaceError",
        "InvalidAccessError",
        "TypeMismatchError",
        "SecurityError",
        "NetworkError",
        "AbortError",
        "URLMismatchError",
        "QuotaExceededError",
        "TimeoutError",
        "InvalidNodeTypeError",
        "DataCloneError",
        "EncodingError",
        "NotReadableError",
        "UnknownError",
        "ConstraintError",
        "DataError",
        "TransactionInactiveError",
        "ReadOnlyError",
        "VersionError",
        "OperationError",
        "NotAllowedError",
        "OptOutError"
        ];

    public string Name { get; }

    public string Message { get; }

    public ExceptionLegacyType Code { get; }

    private DomException(string message = "", string name = "Error")
    {
        Message = message;
        Name = name;
        Code = name switch
        {
            "IndexSizeError" => ExceptionLegacyType.IndexSizeError,
            "DomStringSizeError" => ExceptionLegacyType.DomStringSizeError,
            "HierarchyRequestError" => ExceptionLegacyType.HierarchyRequestError,
            "WrongDocumentError" => ExceptionLegacyType.WrongDocumentError,
            "InvalidCharacterError" => ExceptionLegacyType.InvalidCharacterError,
            "NoDataAllowedError" => ExceptionLegacyType.NoDataAllowedError,
            "NoModificationAllowedError" => ExceptionLegacyType.NoModificationAllowedError,
            "NotFoundError" => ExceptionLegacyType.NotFoundError,
            "NotSupportedError" => ExceptionLegacyType.NotSupportedError,
            "InUseAttributeError" => ExceptionLegacyType.InUseAttributeError,
            "InvalidStateError" => ExceptionLegacyType.InvalidStateError,
            "SyntaxError" => ExceptionLegacyType.SyntaxError,
            "InvalidModificationError" => ExceptionLegacyType.InvalidModificationError,
            "NamespaceError" => ExceptionLegacyType.NamespaceError,
            "InvalidAccessError" => ExceptionLegacyType.InvalidAccessError,
            "ValidationError" => ExceptionLegacyType.ValidationError,
            "TypeMismatchError" => ExceptionLegacyType.TypeMismatchError,
            "SecurityError" => ExceptionLegacyType.SecurityError,
            "NetworkError" => ExceptionLegacyType.NetworkError,
            "AbortError" => ExceptionLegacyType.AbortError,
            "URLMismatchError" => ExceptionLegacyType.UrlMismatchError,
            "QuotaExceededError" => ExceptionLegacyType.QuotaExceededError,
            "TimeoutError" => ExceptionLegacyType.TimeoutError,
            "InvalidNodeTypeError" => ExceptionLegacyType.InvalidNodeTypeError,
            "DataCloneError" => ExceptionLegacyType.DataCloneError,
            _ => ExceptionLegacyType.None
        };
    }

    public static DomException Build(DomExceptionBuilderParams builderParams)
    {
        if (!builderParams.Name.EndsWith("Error") || EXCEPTION_NAMES_TABLE.Contains(builderParams.Name))
        {
            throw new ArgumentException("Exception name must end with 'Error' and" +
                "must not be present in the default exception name table", nameof(builderParams));
        }

        DomException value = new(builderParams.Name, builderParams.Message);

        ArgumentException.ThrowIfNullOrEmpty(builderParams.Name, nameof(builderParams.Name));

        return value;
    }
}
