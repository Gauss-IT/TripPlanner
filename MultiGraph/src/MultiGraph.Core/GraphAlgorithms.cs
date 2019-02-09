using System;
using System.Collections.Generic;
using MultiGraph.Core.Interfaces;

namespace MultiGraph.Core
{
    public class GraphAlgorithms<TVertexValue, TEdgeValue> : IGraphAlgorithms<TVertexValue, TEdgeValue>
        where TVertexValue : class, IVertex
        where TEdgeValue : class, IEdge 
    {
        /// <inheritdoc/>
        public List<Vertex<TVertexValue, TEdgeValue>> BreadthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start)
        {
            var visited = new List<Vertex<TVertexValue, TEdgeValue>>();

            if (!graph.Vertices.Contains(start))
                return new List<Vertex<TVertexValue, TEdgeValue>>();

            var queue = new Queue<Vertex<TVertexValue, TEdgeValue>>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in vertex.GetNeighbors())
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }

            return visited;
        }

        /// <inheritdoc/>
        public List<Vertex<TVertexValue, TEdgeValue>> DepthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start)
        {
            var visited = new List<Vertex<TVertexValue, TEdgeValue>>();

            if (!graph.Vertices.Contains(start))
                return new List<Vertex<TVertexValue, TEdgeValue>>();

            var stack = new Stack<Vertex<TVertexValue, TEdgeValue>>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in vertex.GetNeighbors())
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }

        /// <inheritdoc/>
        public double GetPathCost(List<Edge<TEdgeValue, TVertexValue>> path,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction)
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
        public Dictionary<Vertex<TVertexValue, TEdgeValue>, List<Vertex<TVertexValue, TEdgeValue>>> ShortestPaths(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction)
        {
            throw new NotImplementedException();
        }
    }
}
