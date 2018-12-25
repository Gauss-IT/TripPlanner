using System;
using System.Collections.Generic;

namespace MultiGraph
{
    public class Vortex<TVortexValue, TEdgeValue>
        where TVortexValue : IEquatable<TVortexValue>
        where TEdgeValue : IEquatable<TEdgeValue>
    {
        public TVortexValue Value { get; set; }
        public List<Edge<TEdgeValue, TVortexValue>> Edges { get; set; }

        #region Constructors
        public Vortex()
        {
            Edges = new List<Edge<TEdgeValue, TVortexValue>>();
        }
        public Vortex(IEnumerable<Edge<TEdgeValue, TVortexValue>> edges)
        {
            Edges = new List<Edge<TEdgeValue, TVortexValue>>(edges);
        }
        public Vortex(TVortexValue vortexValue)
        {
            Value = vortexValue;
            Edges = new List<Edge<TEdgeValue, TVortexValue>>();
        }
        #endregion
    }
}
