using MultiGraph.Core;
using System;

namespace MultiGraph.DemoConsole
{
    public class Station : IVertex
    {
        public Guid Id { get; }
        public int Value { get; set; }

        #region Constructors
        public Station() => Id = Guid.NewGuid();
        public Station(Guid id) => Id = id; 
        #endregion
    }
}
