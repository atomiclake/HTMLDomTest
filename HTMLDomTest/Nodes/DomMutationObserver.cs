using HTMLDomTest.Nodes.CharacterData;

namespace HTMLDomTest.Nodes.Documents;

public partial class DomMutationObserver
{
    private Action<IEnumerable<DomMutationRecord>, DomMutationObserver> MutationCallback;

    private IEnumerable<DomNode> Nodes;

    private IEnumerable<DomMutationRecord> RecordQueue;

    public DomMutationObserver(Action<IEnumerable<DomMutationRecord>, DomMutationObserver> mutationCallback)
    {
        MutationCallback = mutationCallback;
        Nodes = [];
        RecordQueue = [];
    }

    public void Observe(DomNode target, MutationObserverInit? options)
    {
        throw new NotImplementedException();
    }

    public void Disconnect()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DomMutationRecord> TakeRecords()
    {
        throw new NotImplementedException();
    }
}
