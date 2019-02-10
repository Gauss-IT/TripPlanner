using MultiGraph.Core;

namespace MultiGraph.Tests
{
    public class DummyVertex : IVertex<int>
    {
        public int Id { get; }
        public int Value { get; set; }

        public DummyVertex()
        {
            Id = 0;
            Value = 0;
        }
    }

    public class DummyEdge : IEdge<int,int>
    {
        public int Id { get; private set; }

        public int Value { get; set; }

        public IVertex<int> FromVertex { get; set; }

        public IVertex<int> ToVertex { get; set; }

        public DummyEdge()
        {
            Id = 0;
        }
    }
}
