using System;
using System.Collections.Generic;

namespace MultiGraph.Core.Interfaces
{
    public interface IGraphAlgorithms<TVertexValue, TEdgeValue> 
        where TVertexValue : class, IVertex
        where TEdgeValue : class, IEdge
    {
        /// <summary>
        /// Implementation of shortest path algorithm
        /// </summary>
        /// <returns>The total cost of the path</returns>
        double GetPathCost(List<Edge<TEdgeValue, TVertexValue>> path,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction);

        /// <summary>
        /// Implementation of shortest path algorithm
        /// </summary>
        /// <returns>Dictionary of vertices and shortest paths</returns>
        Dictionary<Vertex<TVertexValue, TEdgeValue>, List<Vertex<TVertexValue, TEdgeValue>>> ShortestPaths(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction);

        /// <summary>
        /// Implementation of breadth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<Vertex<TVertexValue, TEdgeValue>> BreadthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start);

        /// <summary>
        /// Implementation of depth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<Vertex<TVertexValue, TEdgeValue>> DepthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start);

    }
}
