using System;
using System.Collections.Generic;
using MultiGraph.Core.Interfaces;

namespace MultiGraph.Core
{
    public class GraphAlgorithms<TV, TE> : IGraphAlgorithms<TV, TE>
        where TV : new()
        where TE : new()
    {
        /// <inheritdoc/>
        public List<IVertex<TV>> BreadthFirstSearch(IGraph<TV, TE> graph, IVertex<TV> start)
        {
            var visited = new List<IVertex<TV>>();

            if (!graph.Vertices.Contains(start))
                return new List<IVertex<TV>>();

            var queue = new Queue<IVertex<TV>>();
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
        public List<IVertex<TV>> DepthFirstSearch(IGraph<TV, TE> graph, IVertex<TV> start)
        {
            var visited = new List<IVertex<TV>>();

            if (!graph.Vertices.Contains(start))
                return new List<IVertex<TV>>();

            var stack = new Stack<IVertex<TV>>();
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
        public double GetPathCost(List<IEdge<TE, TV>> path, Func<IEdge<TE, TV>, double> costFunction)
        {
            var distance = 0.0;
            if (path.Count == 0)
                return distance;

            for (var i = 0; i < path.Count; i++)
            {
                if (i < path.Count - 1 && path[i].ToVertex != path[i + 1].FromVertex)
                    throw new ArgumentException("Path is not connected!");

                distance += costFunction(path[i]);
            }
            return distance;
        }

        /// <inheritdoc/>
        public Dictionary<IVertex<TV>, List<IVertex<TV>>> ShortestPaths(IGraph<TV, TE> graph,
            IVertex<TV> start, IVertex<TV> end,
            Func<IEdge<TE, TV>, double> costFunction)
        {
            throw new NotImplementedException();
        }
    }
}
