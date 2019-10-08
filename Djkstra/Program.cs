using System; 
  
public class DijkstrasAlgorithm 
{  
  
    private static readonly int NO_PARENT = -1;  

    private static void dijkstra(int[,] adjacencyMatrix, int startVertex)  
    {  
        int nVertices = adjacencyMatrix.GetLength(0);  
  
        int[] shortestDistances = new int[nVertices];  
  
        bool[] added = new bool[nVertices];  
  

        for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)  
        {  
            shortestDistances[vertexIndex] = int.MaxValue;  
            added[vertexIndex] = false;  
        }  
          
        shortestDistances[startVertex] = 0;  

        int[] parents = new int[nVertices];  
  
        parents[startVertex] = NO_PARENT;  
  
        for (int i = 1; i < nVertices; i++)  
        {  
   
            int nearestVertex = -1;  
            int shortestDistance = int.MaxValue;  
            for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)  
            {  
                if (!added[vertexIndex] && shortestDistances[vertexIndex] < shortestDistance)  
                {  
                    nearestVertex = vertexIndex;  
                    shortestDistance = shortestDistances[vertexIndex];  
                }  
            }  
    
            added[nearestVertex] = true;  
   
            for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)  
            {  
                int edgeDistance = adjacencyMatrix[nearestVertex,vertexIndex];  
                  
                if (edgeDistance > 0 && ((shortestDistance + edgeDistance) < shortestDistances[vertexIndex]))  
                {  
                    parents[vertexIndex] = nearestVertex;  
                    shortestDistances[vertexIndex] = shortestDistance + edgeDistance;  
                }  
            }  
        }  
  
        printSolution(startVertex, shortestDistances, parents);  
    }  

    private static void printSolution(int startVertex, int[] distances, int[] parents)  
    {  
        int nVertices = distances.Length;  
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Vertex\t \t Distance\tPath"); 
        Console.ResetColor(); 
          
        for (int vertexIndex = 0;  
                vertexIndex < nVertices;  
                vertexIndex++)  
        {  
            if (vertexIndex != startVertex)  
            {  
                Console.Write("\n" + startVertex + " --> ");  
                Console.Write(vertexIndex + " \t ");  
                Console.Write(distances[vertexIndex] + "\t\t");  
                printPath(vertexIndex, parents);  
            }  
        }  
    }  
  
    private static void printPath(int currentVertex, int[] parents)  
    {  
          
        if (currentVertex == NO_PARENT)  
        {  
            return;  
        }  
        printPath(parents[currentVertex], parents);  
        Console.Write(currentVertex + " " );
    }  

    public static void Main(String[] args)  
    {  
        int[,] adjacencyMatrix = {  { 0, 4, 0, 3, 0 },  
                                    { 4, 0, 8, 0, 2 },  
                                    { 0, 8, 0, 7, 0 },  
                                    { 3, 0, 7, 0, 9 },  
                                    { 0, 2, 0, 9, 0 },  
                                 };  
        dijkstra(adjacencyMatrix, 0);  
        Console.WriteLine();
        Console.ReadKey();
    }  
}  