using System;
using System.Collections.Generic;

namespace MultiGraph.Core.Interfaces
{
    public interface IGraphAlgorithms<TV, TE>
    {
        /// <summary>
        /// Implementation of shortest path algorithm
        /// </summary>
        /// <returns>The total cost of the path</returns>
        double GetPathCost(List<IEdge<TE,TV>> path, Func<IEdge<TE, TV>, double> costFunction);

        /// <summary>
        /// Implementation of shortest path algorithm
        /// </summary>
        /// <returns>Dictionary of vertices and shortest paths</returns>
        Dictionary<IVertex<TV>, List<IVertex<TV>>> ShortestPaths(IGraph<TV, TE> graph,
            IVertex<TV> start, IVertex<TV> end, Func<IEdge<TE, TV>, double> costFunction);

        /// <summary>
        /// Implementation of breadth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<IVertex<TV>> BreadthFirstSearch(IGraph<TV, TE> graph, IVertex<TV> start);

        /// <summary>
        /// Implementation of depth first search
        /// </summary>
        /// <returns>List of vertices in the order found</returns>
        List<IVertex<TV>> DepthFirstSearch(IGraph<TV, TE> graph, IVertex<TV> start);

    }
}
