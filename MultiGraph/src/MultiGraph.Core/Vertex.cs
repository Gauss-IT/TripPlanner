using MultiGraph.Core;
using MultiGraph.Core.IdManagers;

namespace MultiGraph
{
    public class Vertex<TV> : IVertex<TV>
       where TV : new()
    {
        public TV Value { get; set; }

        public int Id { get; private set; }

        #region Constructors
        public Vertex()
        {
            Id = VertexIdManager.GetNewVertexId();
            Value = new TV();
        }
        
        public Vertex(TV value): this()
        {
            Value = value;
        }
        #endregion
    }
}
