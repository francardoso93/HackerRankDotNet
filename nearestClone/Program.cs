using System.Collections.Generic;
using System;

class Node
{
    public long id;

    public long color;

    public Node(long id, long color)
    {
        this.id = id;
        this.color = color;
    }
}

class Graph
{
    public Dictionary<long, Node> nodes = new Dictionary<long, Node>();
    public Dictionary<long, List<long>> adjacentList = new Dictionary<long, List<long>>();
    public Graph(int verticesAmout)
    {
        inicializeAdjacentList(verticesAmout);
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

    public void CreateNode(long nodeId, long nodeColor)
    {
        nodes.Add(nodeId, new Node(nodeId, nodeColor));
    }

    public long GetSmallerDistanceBetweenTwoNodesOfThisColor(long color)
    {
        bool foundSourceNodeWithColor = false;
        var nextToVisit = new Queue<long>();
        nextToVisit.Enqueue(1); // O primeiro a visitar é a origem do grafo

        var distances = new Dictionary<long, long>();
        while (nextToVisit.Count > 0)
        {
            long nodeId = nextToVisit.Dequeue();
            if (nodes[nodeId].color == color)
            {
                if (foundSourceNodeWithColor) // If source color was found before, then this is destination color node.
                    return distances[nodeId];
                else // This is the source
                {
                    // Zera toda a busca feita até o momento. Antes guardei distances só para saber quem já foi visitado. Agora preciso visitar denovo contando pra valer
                    foundSourceNodeWithColor = true;
                    nextToVisit.Clear(); 
                    distances.Clear();
                    distances.Add(nodeId, 0);
                }
            }

            // Adiciona todos os filhos na fila nextToVisit
            foreach (int adjacent in this.adjacentList[nodeId])
            {
                if (!distances.ContainsKey(adjacent))
                {
                    var previousNodeDistanceValue = distances.ContainsKey(nodeId) ? distances[nodeId] : 0;
                    distances.Add(adjacent, previousNodeDistanceValue + 1); // Nunca vou incrementar o mesmo. Só usar o do vizinho como base de saída.
                    nextToVisit.Enqueue(adjacent);
                }
            }
        }

        return -1; // not reachable node.
    }
}


class Solution
{
    static void Main(string[] args)
    {

        string[] graphNodesEdges = Console.ReadLine().Split(' ');
        int graphNodes = Convert.ToInt32(graphNodesEdges[0]);
        int graphEdges = Convert.ToInt32(graphNodesEdges[1]);

        int[] graphFrom = new int[graphEdges];
        int[] graphTo = new int[graphEdges];

        for (int i = 0; i < graphEdges; i++)
        {
            string[] graphFromTo = Console.ReadLine().Split(' ');
            graphFrom[i] = Convert.ToInt32(graphFromTo[0]);
            graphTo[i] = Convert.ToInt32(graphFromTo[1]);
        }

        long[] ids = Array.ConvertAll(Console.ReadLine().Split(' '), idsTemp => Convert.ToInt64(idsTemp))
        ;
        int val = Convert.ToInt32(Console.ReadLine());

        Graph graph = new Graph(graphNodes);
        for (int i = 0; i < ids.Length; i++)
        {
            graph.CreateNode(i + 1, ids[i]);
        }

        for (int i = 0; i < graphFrom.Length; i++)
        {
            graph.AddEdge(graphFrom[i], graphTo[i]);
        }

        long ans = graph.GetSmallerDistanceBetweenTwoNodesOfThisColor(val);

        Console.WriteLine(ans);
    }
}
