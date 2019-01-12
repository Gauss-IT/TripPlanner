using DotNetGraph;
using System;

namespace MultiGraph.DemoConsoles
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new DotGraph("tripplanning", true);
            var node1 = new DotNode("node1");
            var node2 = new DotNode("node2");
            var node3 = new DotNode("node3");
            var node4 = new DotNode("node4");
            var node5 = new DotNode("node5");
            var edge1 = new DotArrow(node1, node2);
            
            var edge2 = new DotArrow(node1, node3);
            var edge3 = new DotArrow(node2, node5);
            var edge4 = new DotArrow(node2, node4);
            var edge5 = new DotArrow(node3, node3);
            var edge6 = new DotArrow(node4, node2);
            var edge7 = new DotArrow(node5, node1);

            graph.Add(node1);
            graph.Add(node2);
            graph.Add(node3);
            graph.Add(node4);
            graph.Add(node5);

            graph.Add(edge1);
            graph.Add(edge2);
            graph.Add(edge2);
            graph.Add(edge3);
            graph.Add(edge4);
            graph.Add(edge5);
            graph.Add(edge6);
            graph.Add(edge7);

            var dot = graph.Compile();
            Console.WriteLine(dot);

            #region useless
            //var edges = new List<Edge<Route, Station>>()
            //{
            //    new Edge<Route, Station>(new Route{Name="12"},new Station{Value=1}, new Station{Value=2}),
            //    new Edge<Route, Station>(new Route{Name="14"},new Station{Value=1}, new Station{Value=4}),
            //    new Edge<Route, Station>(new Route{Name="23"},new Station{Value=2}, new Station{Value=3}),
            //    new Edge<Route, Station>(new Route{Name="31"},new Station{Value=3}, new Station{Value=1}),
            //    new Edge<Route, Station>(new Route{Name="42"},new Station{Value=4}, new Station{Value=2}),
            //};

            //var graph = new MultiGraph<Station, Route>();

            //foreach (var edge in edges)
            //{
            //    graph.AddEdge(edge);
            //}

            //Console.WriteLine("end");
            #endregion

        }
    }
}
