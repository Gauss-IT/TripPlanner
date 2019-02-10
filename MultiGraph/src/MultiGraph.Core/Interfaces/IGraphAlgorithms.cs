using System;
using System.Collections.Generic;

namespace MultiGraph.Core.Interfaces
{
    public interface IGraphAlgorithms<TV, TE> 
        : IGraphAlgorithms<TV, IVertex<TV>, TE, IEdge<TE, IVertex<TV>>> { }

    public interface IGraphAlgorithms<TV, TVertex, TE, TEdge>
        where TVertex : IVertex<TV>
        where TEdge : IEdge<TE, TVertex>
    {
        /// <summary>
        /// Implementation of shortest path algorithm
        /// </summary>
        /// <returns>The total cost of the path</returns>
        double GetPathCost(List<TEdge> path, Func<TEdge, double> costFunction);

        /// <summary>
        /// Implementation of shortest path algorithm
        /// </summary>
        /// <returns>Dictionary of vertices and shortest paths</returns>
        Dictionary<TVertex, List<TVertex>> ShortestPaths(IGraph<TV, TVertex, TE, TEdge> graph,
            TVertex start, TVertex end, Func<TEdge, double> costFunction);

        /// <summary>
        /// Implementation of breadth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<TVertex> BreadthFirstSearch(IGraph<TV, TVertex, TE, TEdge> graph, TVertex start);

        /// <summary>
        /// Implementation of depth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<TVertex> DepthFirstSearch(IGraph<TV, TVertex, TE, TEdge> graph, TVertex start);

    }
}
