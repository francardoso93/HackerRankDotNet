using System;
using System.Collections.Generic;
using System.IO;

// Não é tão Hard quanto parece, só tenho que prestar atenção em alguns detalhes, como o nó que n
// https://www.hackerrank.com/challenges/ctci-bfs-shortest-reach/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=graphs
class Node
{
    public long id;

    public Node(long id)
    {
        this.id = id;
    }
}

class Graph
{
    public Dictionary<long, Node> nodes = new Dictionary<long, Node>();
    public Dictionary<long, List<long>> adjacentList = new Dictionary<long, List<long>>();
    private int sourceNodeId;
    public Graph(int verticesAmout, int sourceNodeId)
    {
        inicializeAdjacentList(verticesAmout);
        this.sourceNodeId = sourceNodeId;
    }

    private void inicializeAdjacentList(int verticesAmout)
    {
        for (int i = 1; i <= verticesAmout; i++)
        {
            adjacentList.Add(i, new List<long>());
        }
    }

    public void AddEdge(int sourceNodeId, int destinationNodeId)
    {
        if (adjacentList[sourceNodeId].Count < 0)
        {
            adjacentList[destinationNodeId] = new List<long>();
        }
        // Aqui a edge é bidirecional
        adjacentList[sourceNodeId].Add(destinationNodeId);
        adjacentList[destinationNodeId].Add(sourceNodeId);
    }

    public void CreateNode(long nodeId)
    {
        nodes.Add(nodeId, new Node(nodeId));
    }

    public void GetSmallerDistance()
    {
        Queue<int> nextToVisit = new Queue<int>();
        nextToVisit.Enqueue(sourceNodeId); // O primeiro a visitar é a própria origem
        var distances = new Dictionary<long, long>();
        distances[sourceNodeId] = 0;

        while (nextToVisit.Count > 0)
        {
            int nodeId = nextToVisit.Dequeue(); // Pega e tira da fila.
                                                // Esse valida se já chegou ao destino

            foreach (int adjacent in (this.adjacentList[nodeId]))
            {
                if (!distances.ContainsKey(adjacent))
                {
                    var previousNodeDistanceValue = distances.ContainsKey(nodeId) ? distances[nodeId] : 0;
                    distances[adjacent] = previousNodeDistanceValue + 6; // "The distance to our adjacent is just one more than the distance to us" 
                    nextToVisit.Enqueue(adjacent);
                }
            }
        }

        for (int i = 1; i <= nodes.Count; i++)
        {
            if (!distances.ContainsKey(i))
            {
                Console.Write(-1);
                Console.Write(' ');
            }
            else if (i != sourceNodeId)
            {
                Console.Write(distances[i]);
                Console.Write(' ');
            }
        }
    }
}
class Solution
{
    static void Main(String[] args)
    {
        int queries = Convert.ToInt32(Console.ReadLine());
        var graphArr = new Graph[queries];

        for (int j = 0; j < queries; j++)
        {
            string[] graphTotals = Console.ReadLine().Split(' ');
            int graphNodesTotal = Convert.ToInt32(graphTotals[0]);
            int graphEdgesTotal = Convert.ToInt32(graphTotals[1]);
            var edgeList = new List<int[]>();
            for (int i = 0; i < graphEdgesTotal; i++)
            {
                edgeList.Add(Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp)));
            }
            int sourceNodeId = Convert.ToInt32(Console.ReadLine());
            Graph graph = new Graph(graphNodesTotal, sourceNodeId);
            graphArr[j] = graph;
            for (int i = 0; i < graphNodesTotal; i++)
            {
                graph.CreateNode(i + 1);
            }

            for (int i = 0; i < edgeList.Count; i++)
            {
                graph.AddEdge(edgeList[i][0], edgeList[i][1]);
            }
        }

        for (int j = 0; j < graphArr.Length; j++)
        {
            graphArr[j].GetSmallerDistance();
            Console.WriteLine();
        }
    }
}