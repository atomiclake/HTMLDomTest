using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Types;

namespace HTMLDomTest.Events.DomEvents;

[DomInterface("AbortSignal")]
[DomImplementedInterfaces([nameof(DomEventTarget)])]
public class DomAbortSignal : DomEventTarget
{
    [DomName("aborted")]
    public bool Aborted { get; init; }

    [DomName("reason")]
    public object? Reason { get; init; }

    [DomName("onabort")]
    public DomEventHandler OnAbort { get; init; }

    [DomName("abort")]
    public static DomAbortSignal Abort(
        [DomName("reason")] object? reason = null)
    {
        throw new NotImplementedException();
    }

    [DomName("timeout")]
    public static DomAbortSignal Timeout(
        [DomName("milliseconds")] ulong milliseconds)
    {
        throw new NotImplementedException();
    }

    [DomName("_any")]
    public static DomAbortSignal Any(
        [DomName("signals")] IEnumerable<DomAbortSignal> signals)
    {
        throw new NotImplementedException();
    }

    [DomName("throwIfAborted")]
    public void ThrowIfAborted()
    {
        throw new NotImplementedException();
    }
}
