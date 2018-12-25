using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiGraph
{
    public class MultiGraph<TVertexValue, TEdgeValue>
        where TVertexValue : class, IEquatable<TVertexValue>
        where TEdgeValue : class, IEquatable<TEdgeValue>
    {
        public List<Vertex<TVertexValue, TEdgeValue>> Vertices { get; set; }
        public List<Edge<TEdgeValue, TVertexValue>> Edges { get; set; }

        public void AddEdge(Edge<TEdgeValue, TVertexValue> edge)
        {
            if (edge == null)
                throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}' must not be null");

            if (edge.FromVertex == null)
                throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}.{nameof(edge.FromVertex)}' must not be null");

            if (edge.ToVertex == null)
                throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}.{nameof(edge.ToVertex)}' must not be null");

            var fromVertex = Vertices.FirstOrDefault(v => v.Value?.Equals(edge.FromVertex.Value) ?? false);
            if (fromVertex == null)
            {
                var vertex = new Vertex<TVertexValue, TEdgeValue>();
                vertex.Value = edge.FromVertex.Value;
                vertex.Edges.Add(edge);
                Vertices.Add(vertex);
            }
            else
            {
                edge.FromVertex = fromVertex;
                fromVertex.Edges.Add(edge);
                Vertices.Add(edge.FromVertex);
            }
            var toVertex = Vertices.FirstOrDefault(v => v.Value?.Equals(edge.ToVertex) ?? false);
            if (toVertex == null)
            {
                var vertex = new Vertex<TVertexValue, TEdgeValue>();
                vertex.Value = edge.ToVertex.Value;
                vertex.Edges.Add(edge);
                Vertices.Add(vertex);
            }
            else
            {
                edge.ToVertex = toVertex;
                toVertex.Edges.Add(edge);
                Vertices.Add(edge.ToVertex);
            }
        }

        #region Constructors
        public MultiGraph()
        {
            Vertices = new List<Vertex<TVertexValue, TEdgeValue>>();
            Edges = new List<Edge<TEdgeValue, TVertexValue>>();
        }
        public MultiGraph(IEnumerable<Vertex<TVertexValue, TEdgeValue>> vertices)
        {
            Vertices = new List<Vertex<TVertexValue, TEdgeValue>>(vertices);
            Edges = new List<Edge<TEdgeValue, TVertexValue>>();
        }
        public MultiGraph(IEnumerable<Edge<TEdgeValue, TVertexValue>> edges)
        {
            Vertices = new List<Vertex<TVertexValue, TEdgeValue>>();
            Edges = new List<Edge<TEdgeValue, TVertexValue>>(edges);
        }
        public MultiGraph(IEnumerable<Vertex<TVertexValue, TEdgeValue>> vertices, IEnumerable<Edge<TEdgeValue, TVertexValue>> edges)
        {
            Vertices = new List<Vertex<TVertexValue, TEdgeValue>>(vertices);
            Edges = new List<Edge<TEdgeValue, TVertexValue>>(edges);
        }
        #endregion
    }
}
