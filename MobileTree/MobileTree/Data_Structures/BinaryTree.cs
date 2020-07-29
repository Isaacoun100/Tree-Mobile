using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTree.Data_Structures
{
    class BinaryTree
    {

        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) after = after.Left;
                else if (value > after.Data) after = after.Right;
                else return false;
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null) this.Root = newNode;
            else
            {
                if (value < before.Data) before.Left = newNode;
                else before.Right = newNode;
            }

            return true;
        }
        

        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        public Node Find(int value, Node root)
        {
            if()
        }


    }
}
