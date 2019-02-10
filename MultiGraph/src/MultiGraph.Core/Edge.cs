using MultiGraph.Core;
using MultiGraph.Core.IdManagers;

namespace MultiGraph
{
    public class Edge<TE, TV> : IEdge<TE, TV>
        where TV : new()
        where TE : new()
    {
        public int Id { get; }
        public TE Value { get; set; }
        // Admir TODO: Make this a generic vertex container type
        public IVertex<TV> FromVertex { get; private set; }
        public IVertex<TV> ToVertex { get; private set; }

        #region Constructors
        public Edge()
        {
            Id = EdgeIdManager.GetNewEdgeId();
        }

        public Edge(TE edgeValue) : this()
        {
            Value = edgeValue;
            FromVertex = new Vertex<TV>();
            ToVertex = new Vertex<TV>();
        }
        public Edge(TE edgeValue, Vertex<TV> fromVertex, Vertex<TV> toVertex) : this()
        {
            Value = edgeValue;
            FromVertex = fromVertex;
            ToVertex = toVertex;
        }
        public Edge(int id, Vertex<TV> fromVertex, Vertex<TV> toVertex) : this()
        {
            Value = new TE();
            FromVertex = fromVertex;
            ToVertex = toVertex;
        }
        #endregion
    }
}
