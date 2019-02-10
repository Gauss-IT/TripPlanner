using MultiGraph.Core;
using MultiGraph.Core.IdManagers;

namespace MultiGraph
{
    public class Edge<TE, TVertex> : IEdge<TE, TVertex>
        where TE : new()
        where TVertex : new()
    {
        public int Id { get; }
        public TE Value { get; set; }
        public TVertex FromVertex { get; private set; }
        public TVertex ToVertex { get; private set; }

        #region Constructors
        public Edge()
        {
            Id = EdgeIdManager.GetNewEdgeId();
        }

        public Edge(TE edgeValue) : this()
        {
            Value = edgeValue;
            FromVertex = new TVertex();
            ToVertex = new TVertex();
        }
        public Edge(TE edgeValue, TVertex fromVertex, TVertex toVertex) : this()
        {
            Value = edgeValue;
            FromVertex = fromVertex;
            ToVertex = toVertex;
        }
        public Edge(int id, TVertex fromVertex, TVertex toVertex) : this()
        {
            Value = new TE();
            FromVertex = fromVertex;
            ToVertex = toVertex;
        }
        #endregion
    }
}
