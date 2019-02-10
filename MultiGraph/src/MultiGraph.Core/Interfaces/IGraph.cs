using System.Collections.Generic;

namespace MultiGraph.Core
{
    public interface IGraph<TV, TE> : IGraph<TV, IVertex<TV>, TE, IEdge<TE, IVertex<TV>>> { }

    public interface IGraph<TV,TVertex, TE, TEdge>
        where TVertex : IVertex<TV>
        where TEdge : IEdge<TE, TVertex>
    {
        /// <summary>
        /// Vertices of the graph
        /// </summary>
        List<TVertex> Vertices { get; set; }

        /// <summary>
        /// Edges of the graph
        /// </summary>
        List<TEdge> Edges { get; set; }

        /// <summary>
        /// Add vertex to the graph
        /// </summary>
        void AddVertex(TVertex vertex);

        /// <summary>
        /// Add edge to the graph
        /// </summary>
        void AddEdge(TEdge edge);

        /// <summary>
        /// Get vertex neighbors
        /// </summary>
        List<TVertex> GetNeighbors(TVertex vertex);
    }
}
