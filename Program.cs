internal class Program
{
    private static void Main(string[] args)
    {
        Graph g1 = new Graph(5);

        // // 0 --> 1
        // g1.AddEdge(0, 1);

        // // 1 --> 2
        // // 2 --> 1
        g1.AddBidirectEdge(1, 2);
        g1.AddBidirectEdge(2, 3);
        g1.AddBidirectEdge(3, 4);

        Console.WriteLine(g1.CreateNeighboursDisplay());
        Console.WriteLine(GraphAlgorithms.BFS(g1, 2, 4));
    }
}