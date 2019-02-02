using MultiGraph.Core;
using System;

namespace MultiGraph.DemoConsole
{
    public class Route : IEdge
    {
        public Guid Id { get; }

        public string Name { get; set; }
        public double Price { get; set; }

        #region Constructors
        public Route() => Id = Guid.NewGuid();
        public Route(Guid id) => Id = id;
        #endregion
    }
}
