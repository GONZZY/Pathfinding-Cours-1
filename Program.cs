Graph g1 = new Graph(5);

// 0 --> 1
g1.AddEdge(0, 1);

// 1 --> 2
// 2 --> 1
g1.AddBidirectEdge(1, 2);


Console.WriteLine(g1.CreateNeighboursDisplay());
