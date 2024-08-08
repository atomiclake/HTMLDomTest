namespace HTMLDomTest.Exceptions;

public interface IDomExceptionBuilder<TException>
    where TException : DomException
{
    static TException Build(DomExceptionBuilderParams builderParams)
    {
        throw new NotImplementedException();
    }
}
