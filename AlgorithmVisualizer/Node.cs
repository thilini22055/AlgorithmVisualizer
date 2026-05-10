using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    internal class Node
    {
        public int Row;
        public int Col;

        public bool IsWall = false;

        public bool Visited = false;

        public bool IsPath = false;

        public Node Parent = null;

        public Node(int r, int c)
        {
            Row = r;
            Col = c;
        }
    }
}
