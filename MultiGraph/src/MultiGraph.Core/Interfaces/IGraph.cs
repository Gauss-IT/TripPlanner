namespace MultiGraph.Core
{
    public interface IGraph<TVertexValue, TEdgeValue>
        where TVertexValue : class, IVertex
        where TEdgeValue : class, IEdge
    {
        void AddVertex(Vertex<TVertexValue, TEdgeValue> vertex);
        void AddEdge(Edge<TEdgeValue, TVertexValue> edge);
    }
}
