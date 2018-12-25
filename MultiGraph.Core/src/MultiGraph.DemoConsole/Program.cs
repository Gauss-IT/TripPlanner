using MultiGraph;
using System;
using System.Collections.Generic;

namespace MultiGraph.DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var edges = new List<Edge<Route, Station>>()
            {
                new Edge<Route, Station>(new Route{Name="12"},new Station{Value=1}, new Station{Value=2}),
                new Edge<Route, Station>(new Route{Name="14"},new Station{Value=1}, new Station{Value=4}),
                new Edge<Route, Station>(new Route{Name="23"},new Station{Value=2}, new Station{Value=3}),
                new Edge<Route, Station>(new Route{Name="31"},new Station{Value=3}, new Station{Value=1}),
                new Edge<Route, Station>(new Route{Name="42"},new Station{Value=4}, new Station{Value=2}),
            };

            var graph = new MultiGraph<Station, Route>();

            foreach (var edge in edges)
            {
                graph.AddEdge(edge);
            }

            Console.WriteLine("end");


        }
    }
}
