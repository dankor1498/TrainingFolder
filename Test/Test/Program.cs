using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Test
{
    class Program
    {
        class BinaryNode
        {
            int Name;
            string Side;
            public BinaryNode LeftChild;
            public BinaryNode RightChild;
            public BinaryNode(int name)
            {
                Name = name;
                Side = "Top";
            }

            static public void TraversePreorder(BinaryNode node)
            {
                Console.WriteLine(node.Side + " - " + node.Name);
                if (node.LeftChild != null) TraversePreorder(node.LeftChild);
                if (node.RightChild != null) TraversePreorder(node.RightChild);
            }

            public void AddNode(int value)
            {
                if (value < Name)
                {
                    if (LeftChild == null)
                    {
                        LeftChild = new BinaryNode(value);
                        LeftChild.Side = "Left";
                    }
                    else
                    {
                        LeftChild.AddNode(value);
                    }
                }
                else
                {
                    if (RightChild == null)
                    {
                        RightChild = new BinaryNode(value);
                        RightChild.Side = "Right";
                    }
                    else
                    {
                        RightChild.AddNode(value);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            BinaryNode binary = new BinaryNode(0);
            Random random = new Random();
            int value;
            for (int i = 0; i < 5; i++)
            {
                value = random.Next(-10, 10);
                Console.WriteLine(value);
                binary.AddNode(value);
            }
            Console.WriteLine();
            BinaryNode.TraversePreorder(binary);
        }

    }
}


