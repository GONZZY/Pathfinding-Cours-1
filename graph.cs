namespace PathFinding;

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
    private List<int>[] adjacencyNeighborsLists;

    public Graph(int nNodes)
    {
        this.nNodes = nNodes;

        adjacencyNeighborsLists = new List<int>[nNodes];

        for (int i = 0; i < nNodes; ++i)
        {
            adjacencyNeighborsLists[i] = new List<int>();
        }
    }

}