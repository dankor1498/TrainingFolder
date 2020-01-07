using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Collections;

namespace Test
{
    class Program
    {
        class BinaryNode<T> where T: IComparable
        {
            T Name;
            string Side;
            public BinaryNode<T> LeftChild;
            public BinaryNode<T> RightChild;
            public BinaryNode(T name)
            {
                Name = name;
                Side = "Top";
            }

            static public void TraversePreorder(BinaryNode<T> node)
            {
                Console.WriteLine(node.Side + " - " + node.Name);
                if (node.LeftChild != null) TraversePreorder(node.LeftChild);
                if (node.RightChild != null) TraversePreorder(node.RightChild);
            }

            static public void TraverseDepthFirst(BinaryNode<T> node)
            {
                Queue<BinaryNode<T>> binaryNodes = new Queue<BinaryNode<T>>();
                binaryNodes.Enqueue(node);
                while(binaryNodes.Count != 0)
                {
                    BinaryNode<T> binary = binaryNodes.Dequeue();
                    Console.WriteLine(node.Side + " - " + node.Name);
                    if (node.LeftChild != null) binaryNodes.Enqueue(node.LeftChild);
                    if (node.RightChild != null) binaryNodes.Enqueue(node.RightChild);
                }
            }

            public void AddNode(T value)
            {
                if (value.CompareTo(Name) < 0)
                {
                    if (LeftChild == null)
                    {
                        LeftChild = new BinaryNode<T>(value);
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
                        RightChild = new BinaryNode<T>(value);
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
            BinaryNode<int> binary = new BinaryNode<int>(0);
            Random random = new Random();
            int value;
            for (int i = 0; i < 15; i++)
            {
                value = random.Next(-10, 10);
                Console.WriteLine(value);
                binary.AddNode(value);
            }
            Console.WriteLine();
            BinaryNode<int>.TraversePreorder(binary);
            Console.WriteLine();
            BinaryNode<int>.TraversePreorder(binary);
        }

    }
}


