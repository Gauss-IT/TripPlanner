using DotNetGraph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using GraphVizWrapper;
using GraphVizWrapper.Commands;
using GraphVizWrapper.Queries;

namespace MultiGraph.Core
{
    public static class DotNetGraphExtensions
    {
        public static DotGraph ToDotNetGraph<TVertexValue, TEdgeValue>(
            this MultiGraph<TVertexValue, TEdgeValue> graph, string name)
            where TVertexValue: class, IVertex
            where TEdgeValue: class, IEdge
        {
            var vertices = new Dictionary<Guid, DotNode>(graph.Vertices.Count);
            var edges = new Dictionary<Guid, DotArrow>(graph.Edges.Count);
            var result = new DotGraph(name);

            foreach (var vertex in graph.Vertices)
            {
                var node = new DotNode(vertex.Value.Id.ToString());
                vertices.Add(vertex.Value.Id, node);
                result.Add(node);
            }

            foreach (var edge in graph.Edges)
            {
                var arrow = new DotArrow(edge.FromVertex.Value.Id.ToString(), edge.ToVertex.Value.Id.ToString());
                edges.Add(edge.Value.Id, arrow);
                result.Add(arrow);
            }
            return result;
        }

        public static void SaveToDotFile(this DotGraph dotNetGraph, string fileName)
        {
            var dot = dotNetGraph.Compile();
            File.WriteAllText(fileName, dot);
        }

        public static void SaveToSvg(this DotGraph dotNetGraph, string name)
        {
            var svg = new StreamReader(dotNetGraph.ToStream(Enums.GraphReturnType.Svg)).ReadToEnd();
            File.WriteAllText(name, svg);
        }

        public static Image ToPngImage(this DotGraph dotNetGraph)
        {
            return Image.FromStream(dotNetGraph.ToStream(Enums.GraphReturnType.Png));
        }

        public static MemoryStream ToStream(this DotGraph dotNetGraph, Enums.GraphReturnType streamType)
        {
            var dot = dotNetGraph.Compile();
            var wrapper = InitializeWrapper();
            byte[] output = wrapper.GenerateGraph(dot, streamType);
            return new MemoryStream(output);
        }

        private static GraphGeneration InitializeWrapper()
        {
            var getStartProcessQuery = new GetStartProcessQuery();
            var getProcessStartInfoQuery = new GetProcessStartInfoQuery();
            var registerLayoutPluginCommand = new RegisterLayoutPluginCommand(getProcessStartInfoQuery, getStartProcessQuery);
            return new GraphGeneration(getStartProcessQuery, getProcessStartInfoQuery, registerLayoutPluginCommand)
                        {
                            GraphvizPath = @"C:\Program Files (x86)\Graphviz2.38\bin"
                        };
        }
    }
}
