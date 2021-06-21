using Algorithms2021;
using Algorithms2021.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlgorithmTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void GraphCanBreadthFirstSearch()
        {
            // Arrange
            var graph = GraphAlgorithms.GetGraph();

            // Act
            graph.BreadthFirstSearch(graph.Nodes.Where(n => n.Name == "Delta").FirstOrDefault());

            // Assert
            // See console
        }

        [TestMethod]
        public void GraphCanDepthFirstSearch()
        {
            // Arrange
            var graph = GraphAlgorithms.GetGraph();

            // Act
            graph.DepthFirstSearch(graph.Nodes.Where(n => n.Name == "Gamma").FirstOrDefault());

            // Assert
            // See console
        }
    }
}
