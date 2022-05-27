using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw5_algo_lib_cs;

namespace ce100_hw5_algo_test_cs
{
    [TestClass]
    public class Graph_Cycle_Detection_Tests
    {
        [TestMethod]
        public void Graph_Cycle_Detection_Test_1()
        {
            GraphCycleDetection graph = new GraphCycleDetection(9);
            graph.addEdge(1, 2);
            graph.addEdge(1, 3);
            graph.addEdge(1, 4);
            graph.addEdge(1, 5);
            graph.addEdge(2, 6);
            graph.addEdge(2, 7);
            graph.addEdge(3, 8);

            bool result = false;
            Assert.AreEqual(result, graph.isCyclic());

        }

        [TestMethod]
        public void Graph_Cycle_Detection_Test_2()
        {
            GraphCycleDetection graph = new GraphCycleDetection(6);
            graph.addEdge(0, 1);
            graph.addEdge(1, 2);
            graph.addEdge(2, 0);
            graph.addEdge(3, 4);
            graph.addEdge(4, 5);

            bool result = true;
            Assert.AreEqual(result, graph.isCyclic());

        }

        [TestMethod]
        public void Graph_Cycle_Detection_Test_3()
        {
            GraphCycleDetection graph = new GraphCycleDetection(4);
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(1, 2);
            graph.addEdge(2, 0);
            graph.addEdge(2, 3);

            bool result = true;
            Assert.AreEqual(result, graph.isCyclic());

        }
    }

    [TestClass]
    public class Minimum_Spanning_Tree_Tests
    {
        [TestMethod]
        public void Minimum_Spanning_Tree_Test_1()
        {
            int V = 4; // Number of vertices in graph
            int E = 5; // Number of edges in graph
            MinimumSpanningTree graph = new MinimumSpanningTree(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = 10;

            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 6;

            // add edge 0-3
            graph.edge[2].src = 0;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = 5;

            // add edge 1-3
            graph.edge[3].src = 1;
            graph.edge[3].dest = 3;
            graph.edge[3].weight = 15;

            // add edge 2-3
            graph.edge[4].src = 2;
            graph.edge[4].dest = 3;
            graph.edge[4].weight = 4;

            string result = graph.KruskalMST();
            string expected = "(2(source)--> 3(destination) == 4(weight))(0(source)--> 3(destination) == 5(weight))(0(source)--> 1(destination) == 10(weight))";
            Assert.AreEqual(result, expected);

        }

        [TestMethod]
        public void Minimum_Spanning_Tree_Test_2()
        {
            int V = 5; // Number of vertices in graph
            int E = 7; // Number of edges in graph
            MinimumSpanningTree graph = new MinimumSpanningTree(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = 1;

            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 3;

            // add edge 1-3
            graph.edge[2].src = 1;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = 5;

            // add edge 1-4
            graph.edge[3].src = 1;
            graph.edge[3].dest = 4;
            graph.edge[3].weight = 10;

            // add edge 1-2
            graph.edge[4].src = 1;
            graph.edge[4].dest = 2;
            graph.edge[4].weight = 7;

            // add edge 2-4
            graph.edge[5].src = 2;
            graph.edge[5].dest = 4;
            graph.edge[5].weight = 4;

            // add edge 3-4
            graph.edge[6].src = 3;
            graph.edge[6].dest = 4;
            graph.edge[6].weight = 2;

            string result = graph.KruskalMST();
            string expected = "(0(source)--> 1(destination) == 1(weight))(3(source)--> 4(destination) == 2(weight))(0(source)--> 2(destination) == 3(weight))(2(source)--> 4(destination) == 4(weight))";
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Minimum_Spanning_Tree_Test_3()
        {
            int V = 9; // Number of vertices in graph
            int E = 14; // Number of edges in graph
            MinimumSpanningTree graph = new MinimumSpanningTree(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = 4;

            // add edge 0-7
            graph.edge[1].src = 0;
            graph.edge[1].dest = 7;
            graph.edge[1].weight = 8;

            // add edge 1-2
            graph.edge[2].src = 1;
            graph.edge[2].dest = 2;
            graph.edge[2].weight = 8;

            // add edge 1-7
            graph.edge[3].src = 1;
            graph.edge[3].dest = 7;
            graph.edge[3].weight = 11;

            // add edge 7-8
            graph.edge[4].src = 7;
            graph.edge[4].dest = 8;
            graph.edge[4].weight = 7;

            // add edge 2-8
            graph.edge[5].src = 2;
            graph.edge[5].dest = 8;
            graph.edge[5].weight = 2;

            // add edge 8-6
            graph.edge[6].src = 8;
            graph.edge[6].dest = 6;
            graph.edge[6].weight = 6;

            // add edge 2-3
            graph.edge[7].src = 2;
            graph.edge[7].dest = 3;
            graph.edge[7].weight = 7;

            // add edge 2-5
            graph.edge[8].src = 2;
            graph.edge[8].dest = 5;
            graph.edge[8].weight = 4;

            // add edge 6-5
            graph.edge[9].src = 6;
            graph.edge[9].dest = 5;
            graph.edge[9].weight = 2;

            // add edge 3-5
            graph.edge[10].src = 3;
            graph.edge[10].dest = 5;
            graph.edge[10].weight = 14;

            // add edge 3-4
            graph.edge[11].src = 3;
            graph.edge[11].dest = 4;
            graph.edge[11].weight = 9;

            // add edge 5-4
            graph.edge[12].src = 5;
            graph.edge[12].dest = 4;
            graph.edge[12].weight = 10;

            // add edge 7-6
            graph.edge[13].src = 7;
            graph.edge[13].dest = 6;
            graph.edge[13].weight = 1;


            string result = graph.KruskalMST();
            string expected = "(7(source)--> 6(destination) == 1(weight))(2(source)--> 8(destination) == 2(weight))(6(source)--> 5(destination) == 2(weight))(0(source)--> 1(destination) == 4(weight))(2(source)--> 5(destination) == 4(weight))(2(source)--> 3(destination) == 7(weight))(0(source)--> 7(destination) == 8(weight))(3(source)--> 4(destination) == 9(weight))";
            Assert.AreEqual(result, expected);
        }
    }

    [TestClass]
    public class Single_Source_Shortest_Path_Tests
    {
        [TestMethod]
        public void Single_Source_Shortest_Path_Test_1()
        {
            int V = 5;
            int E = 6;

            SingleSourceShortestPath graph = new SingleSourceShortestPath(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = 2;

            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 2;

            // add edge 1-3
            graph.edge[2].src = 1;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = 3;

            // add edge 2-3
            graph.edge[3].src = 2;
            graph.edge[3].dest = 3;
            graph.edge[3].weight = 6;

            // add edge 2-4
            graph.edge[4].src = 2;
            graph.edge[4].dest = 4;
            graph.edge[4].weight = 4;

            // add edge 3-4
            graph.edge[5].src = 3;
            graph.edge[5].dest = 4;
            graph.edge[5].weight = -5;


            string result = "(Vertex = Distance from Source)\r\n" +
                "(0 = 0)\r\n" +
                "(1 = 2)\r\n" +
                "(2 = 2)\r\n" +
                "(3 = 5)\r\n" +
                "(4 = 0)\r\n";

            Assert.AreEqual(SingleSourceShortestPath.BellmanFord(graph, 0), result);
        }

        [TestMethod]
        public void Single_Source_Shortest_Path_Test_2()
        {
            int V = 5;
            int E = 8;

            SingleSourceShortestPath graph = new SingleSourceShortestPath(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = -1;

            // add edge 0-2 
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 4;

            // add edge 1-2 
            graph.edge[2].src = 1;
            graph.edge[2].dest = 2;
            graph.edge[2].weight = 3;

            // add edge 1-3 
            graph.edge[3].src = 1;
            graph.edge[3].dest = 3;
            graph.edge[3].weight = 2;

            // add edge 1-4 
            graph.edge[4].src = 1;
            graph.edge[4].dest = 4;
            graph.edge[4].weight = 2;

            // add edge 3-2 
            graph.edge[5].src = 3;
            graph.edge[5].dest = 2;
            graph.edge[5].weight = 5;

            // add edge 3-1 
            graph.edge[6].src = 3;
            graph.edge[6].dest = 1;
            graph.edge[6].weight = 1;

            // add edge 4-3 
            graph.edge[7].src = 4;
            graph.edge[7].dest = 3;
            graph.edge[7].weight = -3;


            string result = "(Vertex = Distance from Source)\r\n" +
                "(0 = 0)\r\n" +
                "(1 = -1)\r\n" +
                "(2 = 2)\r\n" +
                "(3 = -2)\r\n" +
                "(4 = 1)\r\n";

            Assert.AreEqual(SingleSourceShortestPath.BellmanFord(graph, 0), result);

        }

        [TestMethod]
        public void Single_Source_Shortest_Path_Test_3()
        {
            int V = 4; // Number of vertices in graph
            int E = 5; // Number of edges in graph
            SingleSourceShortestPath graph = new SingleSourceShortestPath(V, E);

            // add edge 0-1
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = 10;

            // add edge 0-2
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 6;

            // add edge 0-3
            graph.edge[2].src = 0;
            graph.edge[2].dest = 3;
            graph.edge[2].weight = 5;

            // add edge 1-3
            graph.edge[3].src = 1;
            graph.edge[3].dest = 3;
            graph.edge[3].weight = 15;

            // add edge 2-3
            graph.edge[4].src = 2;
            graph.edge[4].dest = 3;
            graph.edge[4].weight = 4;

            string result = "(Vertex = Distance from Source)\r\n" +
                "(0 = 0)\r\n" +
                "(1 = 10)\r\n" +
                "(2 = 6)\r\n" +
                "(3 = 5)\r\n";

            Assert.AreEqual(SingleSourceShortestPath.BellmanFord(graph, 0), result);
        }
    }

    [TestClass]
    public class Max_Flow_Tests
    {
        [TestMethod]
        public void Max_Flow_Test_1()
        {
            int[,] graph = new int[,] {
            { 0, 16, 13, 0, 0, 0 }, { 0, 0, 10, 12, 0, 0 },
            { 0, 4, 0, 0, 14, 0 },  { 0, 0, 9, 0, 0, 20 },
            { 0, 0, 0, 7, 0, 4 },   { 0, 0, 0, 0, 0, 0 }
        };

            MaxFlow m = new MaxFlow();

            int result = 23;
            Assert.AreEqual(m.fordFulkerson(graph, 0, 5), result);
        }

        [TestMethod]
        public void Max_Flow_Test_2()
        {
            int[,] graph = new int[,] {
            { 0, 10, 10, 0, 0, 0 }, { 0, 0, 2, 4, 8, 0 },
            { 0, 0, 0, 0, 9, 0 },  { 0, 0, 0, 0, 0, 10 },
            { 0, 0, 0, 6, 0, 10 },   { 0, 0, 0, 0, 0, 0 }
        };
            MaxFlow m = new MaxFlow();
            int result = 19;
            Assert.AreEqual(m.fordFulkerson(graph, 0, 5), result);
        }

        [TestMethod]
        public void Max_Flow_Test_3()
        {
            int[,] graph = new int[,] {
            { 0, 7, 5, 0, 0, 0 }, { 0, 0, 5, 4, 0, 0 },
            { 0, 0, 0, 6, 4, 0 },  { 0, 0, 0, 0, 2, 5 },
            { 0, 0, 0, 0, 0, 6 },   { 0, 0, 0, 0, 0, 0 }
        };
            MaxFlow m = new MaxFlow();
            int result = 11;
            Assert.AreEqual(m.fordFulkerson(graph, 0, 5), result);

        }
    }
}
