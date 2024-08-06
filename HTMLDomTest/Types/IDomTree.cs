namespace HTMLDomTest.Types;

public interface IDomTree<T>
{
    T? Parent { get; }

    IEnumerable<T> Children { get; }

    T? Root { get; }

    T? FirstChild { get; }

    T? LastChild { get; }

    T? PreviousSibling { get; }

    T? NextSibling { get; }

    int Index { get; }

    bool IsDescendant(T tree);

    bool IsInclusiveDescendant(T tree);

    bool IsAncestor(T tree);

    bool IsInclusiveAncestor(T tree);

    bool IsSibling(T tree);

    bool IsInclusiveSibling(T tree);

    bool IsPreceding(T tree);

    bool IsFollowing(T tree);
}
