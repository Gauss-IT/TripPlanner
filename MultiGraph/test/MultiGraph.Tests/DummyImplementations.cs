using MultiGraph.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGraph.Tests
{
    public class DummyVertex : IVertex
    {
        public Guid Id { get; }

        public DummyVertex()
        {
            Id = Guid.NewGuid();
        }
    }

    public class DummyEdge : IEdge
    {
        public Guid Id { get; }

        public DummyEdge()
        {
            Id = Guid.NewGuid();
        }
    }
}
