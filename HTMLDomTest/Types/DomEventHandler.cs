using HTMLDomTest.Nodes.Elements;

namespace HTMLDomTest.Types;

public readonly struct DomEventHandler
{
    // TODO: Add support to internal raw uncompiled handlers
    public Action<DomEvent>? Value { get; }

    // REF: https://html.spec.whatwg.org/multipage/webappapis.html#the-event-handler-processing-algorithm
    public Action<DomEvent>? Listener { get; }

    public DomEventTarget DetermineTarget(DomEventTarget target)
    {
        // FIXME: Use the actual element class once you build them

        if (target is DomElement element && element.NodeName is not "body" or "frameset")
        {
            return target;
        }

        // TODO: Include the WindowEventHandlers mixin logic

        // TODO: Include the window active document logic

        // TODO: Include the relevant global object logic

        throw new NotImplementedException();
    }

    public static implicit operator Action<DomEvent>?(DomEventHandler eventHandler)
    {
        return eventHandler.Listener;
    }
}
