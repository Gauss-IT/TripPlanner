namespace MultiGraph.Core
{
    public interface IEdge<TEdge, TVertex>
    {
        int Id { get; }
        TEdge Value { get; set; }
        IVertex<TVertex> FromVertex { get; }
        IVertex<TVertex> ToVertex { get; }
    }
}
