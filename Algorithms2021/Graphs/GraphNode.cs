using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021.Graphs
{
    public class GraphNode
    {
        public string Name { get; set; }
        public List<GraphNode> AdjacentNodes { get; set; }
        public bool Visited { get; set; }

        public GraphNode(string name)
        {
            Name = name;
            AdjacentNodes = new List<GraphNode>();
        }
    }
}
