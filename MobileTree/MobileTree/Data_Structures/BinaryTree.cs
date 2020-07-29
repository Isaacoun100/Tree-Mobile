using System;
using System.Collections.Generic;
using System.Linq;
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

        private Node Find(int value, Node root)
        {
            if(root.Data == value) return root;
            if(root.Right != null) Find(value, root.Right);
            if(root.Left != null) Find(value, root.Left);
            return null;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;
 
            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {

            if(parent==null) return parent;

            if(key<parent.Data) parent.Left = Remove(parent.Left, key);
            else if (key>parent.Data) parent.Right = Remove(parent.Right, key);
            else
            {
                if (parent.LeftNode == null) return parent.RightNode;
                else if (parent.RightNode == null) return parent.LeftNode;

                parent.Data=MinValue(parent.Right);
                parent.Right=Remove(parent.Right, parent.Data);
            }
            return parent;
        }

        public String TraversePreOrder(Node parent)
        {

            return (TraversePreOrder(parent, "["))+"]";

        }

        private String TraversePreOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result+=parent.Data + "-->";
                result+=TraversePreOrder(parent.LeftNode, result);
                result+=TraversePreOrder(parent.RightNode, result);
            }
            return result;
        }

        public String TraverseInOrder(Node parent)
        {

            return (TraverseInOrder(parent, "["))+"]";

        }

        private String TraverseInOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result+=TraverseInOrder(parent.LeftNode);
                result+=parent.Data + "-->";
                result+=TraverseInOrder(parent.RightNode);
            }

            return result;
        }

        public String TraversePostOrder(Node parent)
        {

            return (TraversePostOrder(parent, "["))+"]";

        }

        private void TraversePostOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result+=TraversePostOrder(parent.LeftNode);
                result+=TraversePostOrder(parent.RightNode);
                result+=parent.Data + "-->";
            }
        }

    }
}
