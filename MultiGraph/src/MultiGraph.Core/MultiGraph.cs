using System.Collections.Generic;
using System.Linq;

namespace MultiGraph.Core
{
    public class MultiGraph<TV, TE> : IGraph<TV, Vertex<TV>, TE, Edge<TE, Vertex<TV>>>
        where TV : new()
        where TE : new()
    {
        public List<Vertex<TV>> Vertices { get; set; }
        public List<Edge<TE, Vertex<TV>>> Edges { get; set; }

        public void AddEdge(Edge<TE, Vertex<TV>> edge)
        {
            //if (edge == null)
            //    throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}' must not be null");

            //if (edge.FromVertex == null)
            //    throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}.{nameof(edge.FromVertex)}' must not be null");

            //if (edge.ToVertex == null)
            //    throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}.{nameof(edge.ToVertex)}' must not be null");

            //var fromVertex = Vertices.FirstOrDefault(v => v.Value?.Equals(edge.FromVertex.Value) ?? false);
            //if (fromVertex == null)
            //{
            //    var vertex = new Vertex<TV>();
            //    vertex.Value = edge.FromVertex.Value;
            //    Vertices.Add(vertex);
            //}
            //else
            //{
            //    edge.FromVertex = fromVertex;
            //    fromVertex.Edges.Add(edge);
            //    Vertices.Add(edge.FromVertex);
            //}
            //var toVertex = Vertices.FirstOrDefault(v => v.Value?.Equals(edge.ToVertex) ?? false);
            //if (toVertex == null)
            //{
            //    var vertex = new Vertex<TV, TE>();
            //    vertex.Value = edge.ToVertex.Value;
            //    vertex.Edges.Add(edge);
            //    Vertices.Add(vertex);
            //}
            //else
            //{
            //    edge.ToVertex = toVertex;
            //    toVertex.Edges.Add(edge);
            //    Vertices.Add(edge.ToVertex);
            //}
        }

        public void AddVertex(Vertex<TV> vertex)
        {
        }

        public List<Vertex<TV>> GetNeighbors(Vertex<TV> vertex)
        {
            return Edges
                .Where(x => x.FromVertex == vertex)
                .Select(x => x.ToVertex)
                // Admir TODO: This casting has to be removed, and edges need to use generic vertex containers
                .Cast<Vertex<TV>>()
                .ToList();
        }

        #region Constructors
        public MultiGraph()
        {
            Vertices = new List<Vertex<TV>>();
            Edges = new List<Edge<TE, Vertex<TV>>>();
        }
        public MultiGraph(IEnumerable<Vertex<TV>> vertices)
        {
            Vertices = new List<Vertex<TV>>(vertices);
            Edges = new List<Edge<TE, Vertex<TV>>>();
        }
        public MultiGraph(IEnumerable<Edge<TE, Vertex<TV>>> edges)
        {
            Vertices = new List<Vertex<TV>>();
            Edges = new List<Edge<TE, Vertex<TV>>>(edges);
        }
        public MultiGraph(IEnumerable<Vertex<TV>> vertices, IEnumerable<Edge<TE, Vertex<TV>>> edges)
        {
            Vertices = new List<Vertex<TV>>(vertices);
            Edges = new List<Edge<TE, Vertex<TV>>>(edges);
        }
        #endregion
    }
}
