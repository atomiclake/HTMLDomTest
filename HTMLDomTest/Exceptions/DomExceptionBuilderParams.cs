namespace HTMLDomTest.Exceptions;

public class DomExceptionBuilderParams
{
    public string Name { get; }

    public string Message { get; set; }

    public DomExceptionBuilderParams(string message = "", string name = "Error")
    {
        Message = message;
        Name = name;
    }
}
