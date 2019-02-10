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
            var edgeValue = 5;
            var edge = new Edge<int, int>(edgeValue);
            Assert.AreEqual(edge.Value, edgeValue);
            Assert.IsNotNull(edge.FromVertex);
            Assert.IsNotNull(edge.ToVertex);
        }
    }
}
