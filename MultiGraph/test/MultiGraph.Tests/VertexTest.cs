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
            var vertex = new Vertex<int>();
            Assert.IsNotNull(vertex.Id);
        }

        [TestMethod]
        public void VertexInitializationWithValueTest()
        {
            var vertex = new Vertex<int>();
            var secondVertex = new Vertex<int>(vertex.Value);
            Assert.AreEqual(vertex.Value, secondVertex.Value);
        }
    }
}
