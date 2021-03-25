using System;
using System.Collections.Generic;

namespace graphSearchStudy2
{
    // Problema de grafo baseado em vários artigos mas principalmente nesse vídeo: https://www.youtube.com/watch?v=zaBhtODEL0w&ab_channel=HackerRank
    class Graph
    {
        public Dictionary<int, Node> nodes = new Dictionary<int, Node>();
        public Dictionary<int, List<int>> adjacentList = new Dictionary<int, List<int>>();
        public Graph(int verticesAmout)
        {
            inicializeAdjacentList(verticesAmout);
        }

        private void inicializeAdjacentList(int verticesAmout)
        {
            for (int i = 0; i < verticesAmout; i++)
            {
                adjacentList.Add(i, new List<int>());
            }
        }

        public void AddEdge(int sourceNodeId, int destinationNodeId)
        {
            if (adjacentList[sourceNodeId].Count < 0)
            {
                adjacentList[destinationNodeId] = new List<int>();
            }
            CreateNodes(sourceNodeId, destinationNodeId);
            adjacentList[sourceNodeId].Add(destinationNodeId);
        }

        private void CreateNodes(int sourceNodeId, int destinationNodeId)
        {
            if (!nodes.ContainsKey(sourceNodeId))
            {
                nodes.Add(sourceNodeId, new Node(sourceNodeId));
            }
            if (!nodes.ContainsKey(destinationNodeId))
            {
                nodes.Add(destinationNodeId, new Node(destinationNodeId));
            }
        }

        public int GetSmallerDistance(int sourceNodeId, int destinationNodeId)
        {
            Queue<int> nextToVisit = new Queue<int>();
            nextToVisit.Enqueue(sourceNodeId); // O primeiro a visitar é a própria origem

            int[] distances = new int[nodes.Count];
            Array.Fill(distances, -1);
            distances[sourceNodeId] = 0;

            while (nextToVisit.Count > 0)
            {
                int nodeId = nextToVisit.Dequeue(); // Pega e tira da fila.                                                  
                if (nodeId == destinationNodeId) // Esse valida se já chegou ao destino
                {
                    return distances[nodeId];
                }
          
                // Adiciona todos os filhos na fila nextToVisit
                foreach (int adjacent in this.adjacentList[nodeId])
                {
                    if (distances[adjacent] == -1) // Só adiciono para a lista itens que ainda não visitei.
                    {
                        distances[adjacent] = distances[nodeId] + 1; // "The distance to our adjacent is just one more than the distance to us" 
                                                                    
                                                                     // Esse 1 poderia ser qualquer outro valor que representasse um tamanho padrão de distância entre dois nós
                        nextToVisit.Enqueue(adjacent);
                    }
                }
            }
            return -1; // Não dá para chegar.
        }
    }

    // A única utilidade dessa classe vai ser para conseguir ver algo específico do nó (obviamente), como qual a sua cor. Visto que para o calculo de distância apenas não precisaria. Aí usaria só INT mesmo.
    class Node
    {
        public int id;

        public int color; // TODO: Preencher no construtor

        public Node(int id)
        {
            this.id = id;
        }
    }


 /*
0-1
|/
2-3
 */
 
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
            Console.WriteLine(graph.GetSmallerDistance(0, 3));
        }
    }
}
