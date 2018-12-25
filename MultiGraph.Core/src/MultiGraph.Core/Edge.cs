using System;

namespace MultiGraph
{
    public class Edge<TEdgeValue, TVortexValue>
        where TVortexValue : IEquatable<TVortexValue>
        where TEdgeValue : IEquatable<TEdgeValue>
    {
        public TEdgeValue Value { get; set; }
        public Vortex<TVortexValue, TEdgeValue> FromVortex { get; set; }
        public Vortex<TVortexValue, TEdgeValue> ToVortex { get; set; }

        #region Constructors
        public Edge() { }
        public Edge(TEdgeValue edgeValue)
        {
            Value = edgeValue;
        }
        public Edge(TEdgeValue edgeValue, TVortexValue fromVortex, TVortexValue toVortex)
        {
            Value = edgeValue;
            FromVortex = new Vortex<TVortexValue, TEdgeValue>(fromVortex);
            ToVortex = new Vortex<TVortexValue, TEdgeValue>(fromVortex);
        }
        public Edge(TVortexValue fromVortex, TVortexValue toVortex)
        {
            FromVortex = new Vortex<TVortexValue, TEdgeValue>(fromVortex);
            ToVortex = new Vortex<TVortexValue, TEdgeValue>(fromVortex);
        }
        #endregion
    }
}
