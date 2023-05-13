namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] table =
            {   // a  b  c  d   
            /*a*/{ 0, 1, 1, 1},
            /*b*/{ 1, 0, 1, 1},
            /*c*/{ 1, 1, 0, 1},
            /*d*/{ 1, 1, 1, 0}
            };

            Graph graph = new Graph(table);

            graph.BFS(0);
            
            Console.WriteLine();

            graph.DFS(0);
        }
    }
}