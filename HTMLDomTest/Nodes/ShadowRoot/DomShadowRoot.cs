using HTMLDomTest.Nodes.Documents;

namespace HTMLDomTest;

public partial class DomShadowRoot : DomDocumentFragment
{
    internal DomShadowRootMode _mode;

    internal bool _delegateFocus;

    internal bool _availableToElementsInternal;

    internal bool _declarative;

    internal DomSlotAssignmentMode _slotAssignment;

    internal bool _cloneable;

    internal bool _serializable;

    public DomShadowRootMode Mode => _mode;

    public bool DelegateFocus => _delegateFocus;

    public DomSlotAssignmentMode SlotAssignment => _slotAssignment;

    public bool Cloneable => _cloneable;

    public bool Serializable => _serializable;

    public Action<DomEvent>? OnSlotChange { get; }

    public bool IsShadowIncludingRoot(DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsShadowIncludingDescendant(DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsShadowIncludingInclusiveDescendant(DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsShadowIncludingAncestor(DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsShadowIncludingInclusiveAncestor(DomNode node)
    {
        throw new NotImplementedException();
    }

    public bool IsClosedShadowHidden(DomNode node)
    {
        throw new NotImplementedException();
    }

    public void Retarget()
    {
        throw new NotImplementedException();
    }
}
