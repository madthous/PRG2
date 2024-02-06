using System.Collections.Generic;

namespace Grafik
{
    //Simple node class, no comments needed
    internal class Node
    {
        public int index;

        public List<Node> neighbors;

        public bool visited;

        public Node cameFrom;

        public Node(int index)
        {
            this.index = index;
            neighbors = new List<Node>();
            visited = false;
            cameFrom = null;
        }
    }
}