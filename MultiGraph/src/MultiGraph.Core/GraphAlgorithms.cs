using System;
using System.Collections.Generic;
using MultiGraph.Core.Interfaces;

namespace MultiGraph.Core
{
    public class GraphAlgorithms<TVertexValue, TEdgeValue> : IGraphAlgorithms<TVertexValue, TEdgeValue>
        where TVertexValue : class, IVertex
        where TEdgeValue : class, IEdge 
    {
        /// </inheritdocs>
        public List<Vertex<TVertexValue, TEdgeValue>> BreadthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction)
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

        /// </inheritdocs>
        public List<Vertex<TVertexValue, TEdgeValue>> DepthFirstSearch(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction)
        {
            throw new NotImplementedException();
        }

        /// </inheritdocs>
        public List<Vertex<TVertexValue, TEdgeValue>> ShortestPath(IGraph<TVertexValue, TEdgeValue> graph,
            Vertex<TVertexValue, TEdgeValue> start, Vertex<TVertexValue, TEdgeValue> end,
            Func<Edge<TEdgeValue, TVertexValue>, double> costFunction)
        {
            throw new NotImplementedException();
        }
    }
}
