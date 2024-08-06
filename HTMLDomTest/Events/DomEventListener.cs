using HTMLDomTest.Events.DomEvents;
using HTMLDomTest.LanguageAttributes;
using HTMLDomTest.Types;

namespace HTMLDomTest.Events;

[DomInterface("EventListener")]
public abstract class DomEventListener
{
    [DomName("type")]
    public string Type { get; set; }

    [DomName("callback")]
    public DomEventHandler Callback { get; set; }

    [DomName("capture")]
    public bool Capture { get; set; }

    [DomName("passive")]
    public bool? Passive { get; set; }

    [DomName("once")]
    public bool Once { get; set; }

    [DomName("signal")]
    public DomAbortSignal? Signal { get; set; }

    [DomName("removed")]
    public bool Removed { get; set; }

    [DomName("handleEvent")]
    public abstract void HandleEvent(
        [DomName("event")] DomEvent domEvent);
}
