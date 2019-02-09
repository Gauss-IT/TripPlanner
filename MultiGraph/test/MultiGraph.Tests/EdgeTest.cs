using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiGraph.Core;

namespace MultiGraph.Tests
{
    [TestClass]
    public class EdgeTest
    {
        [TestMethod]
        public void EdgeInitializationTest()
        {
            var edgeValue = new DummyEdge();
            var edge = new Edge<IEdge,IVertex>(edgeValue);
            Assert.AreEqual(edge.Value, edgeValue);
        }
    }
}
