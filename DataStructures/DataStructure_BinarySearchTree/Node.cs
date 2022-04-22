using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_BinarySearchTree
{
    public class Node
    {
        private int key;
        private Node left;
        private Node right;

        public int Key { get => key; set => key = value; }
        internal Node Left { get => left; set => left = value; }
        internal Node Right { get => right; set => right = value; }

        public Node(int key)
        {
            this.key = key;
        }
    }
}
