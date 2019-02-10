namespace MultiGraph.Core
{
    public interface IEdge<TEdge, TVertex>
    {
        int Id { get; }
        TEdge Value { get; set; }
        TVertex FromVertex { get; }
        TVertex ToVertex { get; }
    }
}
