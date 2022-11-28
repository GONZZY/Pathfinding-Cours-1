

public static class GraphAlgorithms
{
    public static bool BFS(Graph graph, int startingNode, int destinationNode)
    {
        // ---------------------- TEST DE MA MANIÈRE -------------------------- //
        // bool isPathExists = false;
        // List<int> newNeighbours = new List<int>(4);

        // for (int i = 0; i < graph.GetNeighbours(startingNode).Length; i++)
        // {
        //     for (int j = 0; j < graph.GetNeighbours(i).Length; j++)
        //     {
        //         Console.WriteLine($"Neighbour of {i} #{j}: {graph.GetNeighbours(i)[j]}");
        //         newNeighbours.Add(graph.GetNeighbours(i)[j]);
        //     }
        // }

        // Console.WriteLine(newNeighbours[0]);
        // Console.WriteLine(newNeighbours.Count);
        // for (int i = 0; i < newNeighbours.Count; i++)
        // {
        //     Console.WriteLine($"NeighBour #{i}: {newNeighbours[i]}");
        // }

        // if (newNeighbours.Contains(destinationNode))
        // {
        //     isPathExists = true;
        // }
        // return isPathExists;
        // ------------------------- FIN TEST MA MANIÈRE ------------------------- //
        bool isPathExists = false;


        Queue<int> frontier = new Queue<int>();

        List<int> visited = new List<int>();

        frontier.Enqueue(startingNode);
        visited.Add(startingNode);
        int currentNode = startingNode;
        while (frontier.Count != 0)
        {
            int currentNodeNeighbors = frontier.Dequeue();
            int[] currentNodeNeighbours = graph.GetNeighbours(currentNode);
            for (int i = 0; i < currentNodeNeighbours.Length; i++)
            {
                int NeighBour = currentNodeNeighbours[i];
                if (NeighBour == destinationNode)
                {
                    return true;
                }
                if (!visited.Contains(NeighBour))
                {
                    frontier.Enqueue(NeighBour);
                    visited.Add(NeighBour);
                }
            }

        }


        return isPathExists;

    }
}
