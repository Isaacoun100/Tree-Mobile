using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileTree.Data_Structures
{
    class BinaryTree
    {

        public static Node Root { get; set; }

        
        public static void AddRandom(int n){
            for(int i = 0; i < n; i++){
                Random random = new Random();
                int number = random.Next(0,50);
                Add(number);
            }
        }

        public static bool Add(int value)
        {
            Node before = null; 
            Node after = Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) after = after.Left;
                else if (value > after.Data) after = after.Right;
                else return false;
            }

            Node newNode = new Node
            {
                Data = value
            };

            if (Root == null) Root = newNode;
            else
            {
                if (value < before.Data) before.Left = newNode;
                else before.Right = newNode;
            }

            return true;
        }
        

        public static Node Find(int value)
        {
            return Find(value, Root);
        }

        private static Node Find(int value, Node root)
        {
            if(root.Data == value) return root;
            if(root.Right != null) Find(value, root.Right);
            if(root.Left != null) Find(value, root.Left);
            return null;
        }

        private static int MinValue(Node node)
        {
            int minv = node.Data;
 
            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }

            return minv;
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private static Node Remove(Node parent, int key)
        {

            if(parent==null) return parent;

            if(key<parent.Data) parent.Left = Remove(parent.Left, key);
            else if (key>parent.Data) parent.Right = Remove(parent.Right, key);
            else
            {
                if (parent.Left == null) return parent.Right;
                else if (parent.Right == null) return parent.Left;

                parent.Data=MinValue(parent.Right);
                parent.Right=Remove(parent.Right, parent.Data);
            }
            return parent;
        }

        public static String TraversePreOrder()
        {

            return (TraversePreOrder(Root, "["))+"]";

        }

        private static String TraversePreOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result+=parent.Data + "-->";
                result+=TraversePreOrder(parent.Left, "");
                result+=TraversePreOrder(parent.Right, "");
            }
            return result;
        }

        public static String TraverseInOrder()
        {

            return (TraverseInOrder(Root, "["))+"]";

        }

        private static String TraverseInOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result+=TraverseInOrder(parent.Left, "");
                result+=parent.Data + "-->";
                result+=TraverseInOrder(parent.Right, "");
            }

            return result;
        }

        public static String TraversePostOrder()
        {

            return (TraversePostOrder(Root, "["))+"]";

        }

        private static String TraversePostOrder(Node parent, String result)
        {
            if (parent != null)
            {
                result+=TraversePostOrder(parent.Left, "");
                result+=TraversePostOrder(parent.Right, "");
                result+=parent.Data + "-->";
            }
            return result;
        }


        public static String toString()
        {
            return toString("",true,"",Root);
        }

        public static String toString(String prefix, Boolean isTail, String sb, Node head)
        {
            if (head.Right != null)
            {
                sb += toString(prefix + (isTail ? "│   " : "    "), false, "", head.Right);
            }

            sb += prefix + (isTail ? "└──" : "┌──") + "[" + head.Data + "]" + "\n";

            if (head.Left != null)
            {
                sb += toString(prefix + (isTail ? "    " : "│   "), true, "", head.Left);
            }
            return sb;
        }

    }
}
