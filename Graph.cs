namespace Lab11
{
    enum Names : int
    {
        a = 0,
        b = 1,
        c = 2,
        d = 3
    }

    internal class Graph
    {
        private int[,] list;
        private int n;
        public Graph(int n)
        {
            list = new int[n, n];
            this.n = n;
        }

        public Graph(int[,] arr)
        {
            list = arr;
            this.n = arr.GetLength(0);
        }
        public void Add(int from, int to, int cost)
        {
            list[from, to] = cost;
        }

        public void BFS(int from)
        {
            bool[] visited = new bool[n];
            Queue<int> turn = new Queue<int>();
            turn.Enqueue(from);
            visited[from] = true;
            while (turn.Count != 0)
            {
                int index = turn.Dequeue();
                Console.WriteLine((Names)index);

                for (int i = 0; i < n; i++)
                {
                    if (list[index, i] != 0 && !visited[i])
                    {
                        visited[i] = true;
                        turn.Enqueue(i);
                    }
                }
            }
        }

        public void DFS(int from)
        {
            bool[] visited = new bool[n];
            Stack<int> stack = new Stack<int>();

            stack.Push(from);

            while (stack.Count != 0)
            {
                int index = stack.Pop(); 

                if (visited[index] != true) 
                    Console.WriteLine((Names)index);

                visited[index] = true; 

                for (int i = 0; i < n; i++)
                {
                    if (visited[i] != true && list[index, i] != 0)
                    {
                        stack.Push(i); 
                    }
                }
            }
        }
    }
}
