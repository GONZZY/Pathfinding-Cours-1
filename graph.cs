using System.Text;


// Un graphe qui a toujours nNodes nombre de noeuds (peut pas changer le nombre de noeuds pendant 
// l'exécution, mais permet l'ajout de chemin après construction)
public class Graph
{
    // Graphe statique donc le nombre de noeuds ne changera pas
    // readonly -> peut seulement être affecté dans un constructeur, ne peut changer après
    // Les nodes sont les vertices
    public readonly int nNodes;

    // On va créer un tableau de listes de int nVoisinsNodes qui sont respectivement les voisins des vertices
    // Ex: nodes[0] = voisinsvertices[0]
    // Nous utilisons des listes pour permettre l'ajout dynamique de CHEMINS (pas de noeuds) pendant l'exécution
    private SortedSet<int>[] adjacencyNeighborsLists;

    public Graph(int nNodes)
    {
        this.nNodes = nNodes;

        adjacencyNeighborsLists = new SortedSet<int>[nNodes];

        for (int i = 0; i < nNodes; ++i)
        {
            adjacencyNeighborsLists[i] = new SortedSet<int>();
        }
    }
    // Ajouter UN chemin direct unidirectionnel entre le noeud identifié par IDnodeA et le IDnodeB
    public void AddEdge(int IDnodeA, int IDnodeB)
        => adjacencyNeighborsLists[IDnodeA].Add(IDnodeB);

    // Ajouter un chemin bidirectionnel
    public void AddBidirectEdge(int IDnodeA, int IDnodeB)
    {
        if (adjacencyNeighborsLists[IDnodeA].Contains(IDnodeB))
            return;
        AddEdge(IDnodeA, IDnodeB);
        AddEdge(IDnodeB, IDnodeA);
    }
    // ToArray retourne un tableau contenant les éléments de la liste
    // Ceci fait une copie et ne retourne pas la liste en tant que telle
    public int[] GetNeighbours(int IDnode) => adjacencyNeighborsLists[IDnode].ToArray();
    public SortedSet<int> GetNeighboursUnsafe(int IDNode) => adjacencyNeighborsLists[IDNode];

    // Crée un string des voisins comme suit:
    //
    // Node 0: 1,2, ...
    // Node 1: 3,2, ...
    // Node 2: 3,5, ...
    // ...
    public string CreateNeighboursDisplay()
    {
        // La capacité de notre StringBuilder peut être déterminer
        // Permet de ne pas avoir a faire pleins de copies
        // Rapidement on met nNodes * 10, mais ceci n'est pas exacte.
        StringBuilder sb = new StringBuilder(nNodes * 10);
        for (int i = 0; i < nNodes; ++i)
        {
            int[] currentNodeNeighbors = GetNeighbours(i);
            sb.Append($"Node {i}: ");
            for (int j = 0; j < currentNodeNeighbors.Length; j++)
            {
                sb.Append($"{currentNodeNeighbors[j]} ");
            }
            sb.Append("\n");
        }
        return sb.ToString();
    }
}