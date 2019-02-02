using DotNetGraph;
using System;
using System.Collections.Generic;

namespace MultiGraph.Core
{
    public static class Serializers
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
    }
}
