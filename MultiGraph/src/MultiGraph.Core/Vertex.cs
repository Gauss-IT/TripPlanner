using MultiGraph.Core;
using System;
using System.Collections.Generic;

namespace MultiGraph
{
    public class Vertex<TVertexValue, TEdgeValue>
        where TVertexValue : IVertex
        where TEdgeValue : IEdge
    {
        public TVertexValue Value { get; set; }
        public List<Edge<TEdgeValue, TVertexValue>> Edges { get; set; }

        #region Constructors
        public Vertex()
        {
            Edges = new List<Edge<TEdgeValue, TVertexValue>>();
        }
        public Vertex(IEnumerable<Edge<TEdgeValue, TVertexValue>> edges)
        {
            Edges = new List<Edge<TEdgeValue, TVertexValue>>(edges);
        }
        public Vertex(TVertexValue vertexValue)
        {
            Value = vertexValue;
            Edges = new List<Edge<TEdgeValue, TVertexValue>>();
        }
        #endregion
    }
}
