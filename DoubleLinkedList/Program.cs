using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoubleLinkedListNode<int> node0 = new DoubleLinkedListNode<int>() { Value = 4 };
            //DoubleLinkedListNode<int> node1 = new DoubleLinkedListNode<int>() { Value = 5, Next = node0 };
            //DoubleLinkedListNode<string> node2 = new DoubleLinkedListNode<string>() { Value = "Hello, World!" };

            //Console.WriteLine("Value: {0}", node1?.Value);
            //Console.WriteLine(" Next: {0}", node1?.Next.Value);
            //Console.WriteLine("Value: {0}", node2?.Value);
            //Console.WriteLine(" Next: {0}", node2?.Next);

            ////DoubleLinkedList list;
            //object x = null;
            //x = 4;
            //x = x ?? 5;
            //Console.WriteLine(x);

            //int? y = 2;
            ////y = null;
            //y = y ?? 3;
            //Console.WriteLine(y);

            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            Console.WriteLine("Count: {0}\nFirst value: {1}\nLast value: {2}\n", list.Count, list.First?.Value, list.Last?.Value);

            list.AddLast(1);
            list.AddLast(2);
            list.AddFirst(0);
            Console.WriteLine("Count: {0}\nFirst value: {1}\nLast value: {2}\n", list.Count, list.First?.Value, list.Last?.Value);

            list.Reverse();
            Console.WriteLine("Count: {0}\nFirst value: {1}\nLast value: {2}\n", list.Count, list.First?.Value, list.Last?.Value);
        }
    }
}
