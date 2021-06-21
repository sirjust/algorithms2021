using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms2021.Graphs
{
    public static class GraphAlgorithms
    {
        public static void AddNodesToGraph()
        {
            var graph = GetGraph();

            graph.BreadthFirstSearch(graph.Nodes.Where(n => n.Name == "Gamma").FirstOrDefault());
            Console.WriteLine("============\n");
            graph.DepthFirstSearch(graph.Nodes.Where(n => n.Name == "Alpha").FirstOrDefault());
            Console.WriteLine("============\n");
            graph.DepthFirstSearch(graph.Nodes.Where(n => n.Name == "Delta").FirstOrDefault());
        }

        public static Graph GetGraph()
        {
            var graph = new Graph();
            var alpha = new GraphNode("Alpha");
            var beta = new GraphNode("Beta") { AdjacentNodes = new List<GraphNode> { alpha } };
            var gamma = new GraphNode("Gamma") { AdjacentNodes = new List<GraphNode> { alpha } };
            var delta = new GraphNode("Delta") { AdjacentNodes = new List<GraphNode> { alpha, beta, gamma } };
            gamma.AdjacentNodes.Add(delta);

            graph.AddNode(alpha);
            graph.AddNode(beta);
            graph.AddNode(gamma);
            graph.AddNode(delta);

            return graph;
        }
    }
}
