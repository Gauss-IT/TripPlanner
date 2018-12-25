using System;

namespace MultiGraph
{
    public class Edge<TEdgeValue, TVertexValue>
        where TVertexValue : IEquatable<TVertexValue>
        where TEdgeValue : IEquatable<TEdgeValue>
    {
        public TEdgeValue Value { get; set; }
        public Vertex<TVertexValue, TEdgeValue> FromVertex { get; set; }
        public Vertex<TVertexValue, TEdgeValue> ToVertex { get; set; }

        #region Constructors
        public Edge() { }
        public Edge(TEdgeValue edgeValue)
        {
            Value = edgeValue;
        }
        public Edge(TEdgeValue edgeValue, TVertexValue fromVertex, TVertexValue toVertex)
        {
            Value = edgeValue;
            FromVertex = new Vertex<TVertexValue, TEdgeValue>(fromVertex);
            ToVertex = new Vertex<TVertexValue, TEdgeValue>(fromVertex);
        }
        public Edge(TVertexValue fromVertex, TVertexValue toVertex)
        {
            FromVertex = new Vertex<TVertexValue, TEdgeValue>(fromVertex);
            ToVertex = new Vertex<TVertexValue, TEdgeValue>(fromVertex);
        }
        #endregion
    }
}
