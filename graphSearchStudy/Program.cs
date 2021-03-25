using System;
using System.Collections.Generic;
using System.Linq;

namespace graphSearchStudy
{

    class Graph
    {

        // No. of vertices     
        private int _V;

        //Adjacency Lists 
        LinkedList<int>[] _adj;

        public Graph(int amountOfVertices) // V is amount of Vertices
        {
            _adj = new LinkedList<int>[amountOfVertices];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>(); // Vertice 0 tem essa lista de adjacentes
            }
            _V = amountOfVertices;
        }

        // Function to add an edge into the graph 
        public void AddEdge(int sourceVertice, int destinationVertice)
        {
            _adj[sourceVertice].AddLast(destinationVertice); // Aqui é o pulo do gato. A partir do vértice V dá para ir para o vérice W. O importante é a origem ser uma CHAVE.

        }


        public int[] ShortestPath(int startId) // Printa a ordem dos vertices colocados no array
        {
            // Create a queue for BFS 
            LinkedList<int> queue = new LinkedList<int>();
            queue.AddLast(startId);

            int[] distances = new int[_V];
            Array.Fill(distances, -1); // Se não tiver como visitar um certo node, é pra ficar -1
                                       // Aí na real nem preciso mais do visited, já que todos não visited serão valor -1s
                                       

            // Mark the current node as 
            // visited and enqueue it 

            while (queue.Any()) // Is not empty
            {
                // Faz o que tem que fazer com esse vertice, e depois coloca todos os adjacentes na fila.

                // distances[queue.First]

                LinkedList<int> list = _adj[startId]; // Colocando numa lista todos os adjacentes desse vértices

                foreach (var val in list)
                {
                    if (val!=-1)
                    {
                        queue.AddLast(val);
                    }
                }
            }
            return distances;
        }

        public void BFS(int startId) // Printa a ordem dos vertices colocados no array
        {

            // Mark all the vertices as not
            // visited(By default set as false) 
            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                visited[i] = false;

            // Create a queue for BFS 
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as 
            // visited and enqueue it 
            visited[startId] = true;
            queue.AddLast(startId);

            while (queue.Any())
            {

                // Dequeue a vertex from queue 
                // and print it
                startId = queue.First();
                Console.Write(startId + " ");
                queue.RemoveFirst();

                // Get all adjacent vertices of the 
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it 
                // visited and enqueue it 
                LinkedList<int> list = _adj[startId];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }
    }


    class Program
    {


        // Driver code
        static void Main(string[] args)
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);
        }
    }
}