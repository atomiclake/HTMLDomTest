using HTMLDomTest.Nodes.Elements;

namespace HTMLDomTest.Nodes.Documents;

public class DomDocumentFragment : DomNode
{
    public DomElement? Host { get; set; }

    // TODO: Check if this is correct
    public bool IsHostIncludingInclusiveAncestorOf(DomDocumentFragment fragment)
    {
        return
            IsInclusiveAncestor(fragment) ||
            
                fragment.Root is DomDocumentFragment f &&
                f.Host is not null and DomElement fragemntRootHost &&
                IsInclusiveAncestor(fragemntRootHost)
            ;
    }
}
