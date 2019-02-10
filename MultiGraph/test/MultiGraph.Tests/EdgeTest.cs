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
            var edgeValue = new Edge<int, int>();
            var edge = new Edge<int, int>(edgeValue.Value);
            Assert.AreEqual(edge.Value, edgeValue);
        }
    }
}
