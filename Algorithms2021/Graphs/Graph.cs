using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms2021.Graphs
{
    public class Graph
    {
        public List<GraphNode> Nodes { get; set; }

        public Graph()
        {
            Nodes = new List<GraphNode>();
        }

        public void ClearVisited()
        {
            foreach(GraphNode node in Nodes)
            {
                node.Visited = false;
            }
        }

        public void DepthFirstSearch(GraphNode root)
        {
            if (root == null) return;
            Console.WriteLine($"Node {root.Name} visited");
            root.Visited = true;
            foreach(GraphNode node in root.AdjacentNodes)
            {
                if (!node.Visited) DepthFirstSearch(node);
            }
        }

        public void BreadthFirstSearch(GraphNode root)
        {
            Queue<GraphNode> queue = new Queue<GraphNode>();
            root.Visited = true;
            queue.Enqueue(root);

            while(!(queue.Count == 0))
            {
                GraphNode node = queue.Dequeue();
                Console.WriteLine($"Node {node.Name} visited");
                node.Visited = true;
                foreach(GraphNode adjacentNode in node.AdjacentNodes)
                {
                    if (!adjacentNode.Visited)
                    {
                        // Console.WriteLine($"Node {adjacentNode.Name} visited");
                        adjacentNode.Visited = true;
                        queue.Enqueue(adjacentNode);
                    }
                }
            }
        }

        public void AddNode(GraphNode node)
        {
            Nodes.Add(node);
        }
    }
}
