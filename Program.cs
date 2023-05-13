using System.Text;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] table =
            {   // a  b  c  d   
            /*a*/{ 0, 1, 1, 1},
            /*b*/{ 1, 0, 1, 1},
            /*c*/{ 1, 1, 0, 1},
            /*d*/{ 1, 1, 1, 0}
            };

            Graph graph = new Graph(table);
            Console.WriteLine("Обхід в ширину неорієнтованого графа, представленого матрицею суміжності");

            graph.BFS(0);
            
            Console.WriteLine("Обхід в глибину неорієнтованого графа, представленого матрицею суміжності");

            graph.DFS(0);


            OOPGraph graph1 = new OOPGraph();
            for(int i = 0; i<=4;i++)
            {
                graph1.AddNode(i);
            }

            graph1.AddEdge(0,1);
            graph1.AddEdge(0,3);
            graph1.AddEdge(0,4);
            graph1.AddEdge(1,2);
            graph1.AddEdge(2,4);
            graph1.AddEdge(3,4);

            Console.WriteLine("Обхід в ширину орієнтованого графа, представленого списком суміжності");
            
            graph1.BFS(0);

            Console.WriteLine("Обхід в глибину орієнтованого графа, представленого списком суміжності");

            graph1.DFS(0);

        }
    }
}