using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiGraph
{
    public class MultiGraph<TVortexValue, TEdgeValue>
        where TVortexValue : class, IEquatable<TVortexValue>
        where TEdgeValue : class, IEquatable<TEdgeValue>
    {
        public List<Vortex<TVortexValue, TEdgeValue>> Vertices { get; set; }
        public List<Edge<TEdgeValue, TVortexValue>> Edges { get; set; }

        public void AddEdge(Edge<TEdgeValue, TVortexValue> edge)
        {
            if (edge == null)
                throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}' must not be null");

            if (edge.FromVortex == null)
                throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}.{nameof(edge.FromVortex)}' must not be null");

            if (edge.ToVortex == null)
                throw new ArgumentNullException(nameof(edge), $"the parameter '{nameof(edge)}.{nameof(edge.ToVortex)}' must not be null");

            var fromVortex = Vertices.FirstOrDefault(v => v.Value?.Equals(edge.FromVortex.Value) ?? false);
            if (fromVortex == null)
            {
                var vortex = new Vortex<TVortexValue, TEdgeValue>();
                vortex.Value = edge.FromVortex.Value;
                vortex.Edges.Add(edge);
                Vertices.Add(vortex);
            }
            else
            {
                edge.FromVortex = fromVortex;
                fromVortex.Edges.Add(edge);
                Vertices.Add(edge.FromVortex);
            }
            var toVortex = Vertices.FirstOrDefault(v => v.Value?.Equals(edge.ToVortex) ?? false);
            if (toVortex == null)
            {
                var vortex = new Vortex<TVortexValue, TEdgeValue>();
                vortex.Value = edge.ToVortex.Value;
                vortex.Edges.Add(edge);
                Vertices.Add(vortex);
            }
            else
            {
                edge.ToVortex = toVortex;
                toVortex.Edges.Add(edge);
                Vertices.Add(edge.ToVortex);
            }
        }

        #region Constructors
        public MultiGraph()
        {
            Vertices = new List<Vortex<TVortexValue, TEdgeValue>>();
            Edges = new List<Edge<TEdgeValue, TVortexValue>>();
        }
        public MultiGraph(IEnumerable<Vortex<TVortexValue, TEdgeValue>> vertices)
        {
            Vertices = new List<Vortex<TVortexValue, TEdgeValue>>(vertices);
            Edges = new List<Edge<TEdgeValue, TVortexValue>>();
        }
        public MultiGraph(IEnumerable<Edge<TEdgeValue, TVortexValue>> edges)
        {
            Vertices = new List<Vortex<TVortexValue, TEdgeValue>>();
            Edges = new List<Edge<TEdgeValue, TVortexValue>>(edges);
        }
        public MultiGraph(IEnumerable<Vortex<TVortexValue, TEdgeValue>> vertices, IEnumerable<Edge<TEdgeValue, TVortexValue>> edges)
        {
            Vertices = new List<Vortex<TVortexValue, TEdgeValue>>(vertices);
            Edges = new List<Edge<TEdgeValue, TVortexValue>>(edges);
        }
        #endregion
    }
}
