namespace Lab11
{
    public class Edge
    {
        public Node ConnectedNode { get; set; }
        public Edge(Node connectedNode)
        {
            ConnectedNode = connectedNode;
        }

    }

    public class Node
    {
        public readonly List<Edge> Edges = new List<Edge>();
        public readonly int NodeNumber;

        public Node(int number)
        {
            NodeNumber = number;
        }

        public void AddEdge(Node node)
        {
            Edges.Add(new Edge(node));
        }

        public override string ToString() => NodeNumber.ToString();
    }

    public class OOPGraph
    {
        public List<Node> Nodes { get; }

        public OOPGraph()
        {
            Nodes = new List<Node>();
        }
        public void AddNode(int nodeName)
        {
            Nodes.Add(new Node(nodeName));
        }

        public Node FindNode(int nodeName)
        {
            foreach (var n in Nodes)
            {
                if (n.NodeNumber == nodeName)
                {
                    return n;
                }
            }

            return null;
        }

        public void AddEdge(int firstName, int secondName)
        {
            var n1 = FindNode(firstName);
            var n2 = FindNode(secondName);

            if (n2 != null && n1 != null)
            {
                n1.AddEdge(n2);
            }
        }

        public void BFS(int from)
        {
            List<GraphNodeInfo> infos = new List<GraphNodeInfo>();
            foreach (var n in Nodes)
            {
                infos.Add(new GraphNodeInfo(n));
            }
            Queue<int> turn = new Queue<int>();
            turn.Enqueue(from);
            infos[from].IsUnvisited = false;
            while (turn.Count != 0)
            {
                int index = turn.Dequeue();
                Console.WriteLine(index+1);

                foreach(var item in infos[index].Node.Edges)
                { 
                    if (infos[item.ConnectedNode.NodeNumber].IsUnvisited)
                    {
                        infos[item.ConnectedNode.NodeNumber].IsUnvisited = false;
                        turn.Enqueue(item.ConnectedNode.NodeNumber);
                    }
                }
            }
        }

        public void DFS(int from)
        {
            List<GraphNodeInfo> infos = new List<GraphNodeInfo>();
            foreach (var n in Nodes)
            {
                infos.Add(new GraphNodeInfo(n));
            }
          
            Stack<int> stack = new Stack<int>();
            stack.Push(from);

            while (stack.Count != 0)
            {
                int index = stack.Pop();

                if (infos[index].IsUnvisited)
                    Console.WriteLine(index+1);

                infos[index].IsUnvisited = false;

                foreach (var item in infos[index].Node.Edges)
                {
                    if (infos[item.ConnectedNode.NodeNumber].IsUnvisited)
                    {
                        stack.Push(item.ConnectedNode.NodeNumber);
                    }
                }
            }
        }
        internal class GraphNodeInfo
        {
            public Node Node { get; set; }
            public bool IsUnvisited { get; set; }
            public Node PreviousNode { get; set; }
            public GraphNodeInfo(Node node)
            {
                Node = node;
                IsUnvisited = true;
                PreviousNode = null;
            }
        }
    }
}
