using HTMLDomTest.LanguageAttributes;

namespace HTMLDomTest;

[DomInterface("EventListener")]
public abstract class DomEventListener
{
    [DomName("handleEvent")]
    public abstract void HandleEvent(
        [DomName("event")] DomEvent domEvent);
}
