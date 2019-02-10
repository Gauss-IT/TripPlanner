using System;
using System.Collections.Generic;
using MultiGraph.Core.Interfaces;

namespace MultiGraph.Core
{
    public class GraphAlgorithms<TV, TVertex, TE, TEdge> 
        : IGraphAlgorithms<TV, TVertex, TE, TEdge>
        where TV : new()
        where TE : new()
        where TVertex : IVertex<TV>
        where TEdge : IEdge<TE, TVertex>
    {
        
        /// <inheritdoc/>
        public List<TVertex> BreadthFirstSearch(IGraph<TV, TVertex, TE, TEdge> graph,
            TVertex start)
        {
            var visited = new List<TVertex>();

            if (!graph.Vertices.Contains(start))
                return new List<TVertex>();

            var queue = new Queue<TVertex>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.GetNeighbors(vertex))
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }

            return visited;
        }

        /// <inheritdoc/>
        public List<TVertex> DepthFirstSearch(IGraph<TV, TVertex, TE, TEdge> graph, 
            TVertex start)
        {
            var visited = new List<TVertex>();

            if (!graph.Vertices.Contains(start))
                return new List<TVertex>();

            var stack = new Stack<TVertex>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.GetNeighbors(vertex))
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }

        /// <inheritdoc/>
        public double GetPathCost(List<TEdge> path, Func<TEdge, double> costFunction)
        {
            var distance = 0.0;
            if (path.Count == 0)
                return distance;

            for (var i = 0; i < path.Count; i++)
            {
                if (i < path.Count - 1 && path[i].ToVertex.Id != path[i + 1].FromVertex.Id)
                    throw new ArgumentException("Path is not connected!");

                distance += costFunction(path[i]);
            }
            return distance;
        }

        /// <inheritdoc/>
        public Dictionary<TVertex, List<TVertex>> ShortestPaths(IGraph<TV, TVertex, TE, TEdge> graph,
            TVertex start, TVertex end, Func<TEdge, double> costFunction)
        {
            throw new NotImplementedException();
        }
    }
}
