using System.Collections.Generic;

namespace MultiGraph.Core
{
    public interface IGraph<TVertexValue, TEdgeValue>
        where TVertexValue : class, IVertex
        where TEdgeValue : class, IEdge
    {
        /// <summary>
        /// Vertices of the graph
        /// </summary>
        List<Vertex<TVertexValue, TEdgeValue>> Vertices { get; set; }

        /// <summary>
        /// Edges of the graph
        /// </summary>
        List<Edge<TEdgeValue, TVertexValue>> Edges { get; set; }

        /// <summary>
        /// Add vertex to the graph
        /// </summary>
        void AddVertex(Vertex<TVertexValue, TEdgeValue> vertex);

        /// <summary>
        /// Add edge to the graph
        /// </summary>
        void AddEdge(Edge<TEdgeValue, TVertexValue> edge);
    }
}
