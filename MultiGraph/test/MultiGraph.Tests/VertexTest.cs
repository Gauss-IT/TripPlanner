using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiGraph.Core;

namespace MultiGraph.Tests
{
    [TestClass]
    public class VertexTest
    {
        [TestMethod]
        public void VertexInitializationTest()
        {
            var vertex = new Vertex<IVertex, IEdge>();
            Assert.IsNotNull(vertex.Edges);
        }

        [TestMethod]
        public void VertexInitializationWithValueTest()
        {
            var vertex = new Vertex<IVertex, IEdge>();
            var secondVertex = new Vertex<IVertex, IEdge>(vertex.Value);
            Assert.IsNotNull(vertex.Edges);
            Assert.AreEqual(vertex.Value, secondVertex.Value);
        }
        [TestMethod]
        public void VertexInitializationWithListValueTest()
        {
            var vertex = new Vertex<IVertex, IEdge>();
            var secondVertex = new Vertex<IVertex, IEdge>(vertex.Value);
            Assert.IsNotNull(vertex.Edges);
            Assert.AreEqual(vertex.Value, secondVertex.Value);
            
        }
    }
}
