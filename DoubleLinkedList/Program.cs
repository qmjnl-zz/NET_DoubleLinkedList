using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int[] vec = new int[size] { 4, 1, 5, 7, 2 };

            DoubleLinkedList<int> list = new DoubleLinkedList<int>();

            list.AddFirst(vec[1]);
            list.AddLast(vec[2]);
            list.AddLast(vec[3]);
            list.AddFirst(vec[0]);
            list.AddLast(vec[4]);

            /* ***** */

            Console.WriteLine("\n  Input data Test\n-------------------\n");

            IDoubleLinkedListNode<int> Temp = list.First;
            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(vec[i], Temp.Value);
                Console.WriteLine("  Pos: {0,2},  Value: {1,2}\n", i, Temp.Value);
                Temp = Temp.Next;
            }

            /* ***** */

            Console.WriteLine("\n  Reverse Test\n----------------\n");

            list.Reverse();
            Temp = list.First;
            for (int i = size - 1; i >= 0; i--)
            {
                Assert.AreEqual(vec[i], Temp.Value);
                Console.WriteLine("  Pos: {0,2},  Value: {1,2}\n", (size - 1) - i, Temp.Value);
                Temp = Temp.Next;
            }
        }
    }
}
