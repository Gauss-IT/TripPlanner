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
        /// <returns>List of vertices in the order found</returns>
        List<Vertex<TVertexValue, TEdgeValue>> ShortestPath(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end, 
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction);

        /// <summary>
        /// Implementation of breadth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<Vertex<TVertexValue, TEdgeValue>> BreadthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction);

        /// <summary>
        /// Implementation of depth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<Vertex<TVertexValue, TEdgeValue>> DepthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction);

    }
}
