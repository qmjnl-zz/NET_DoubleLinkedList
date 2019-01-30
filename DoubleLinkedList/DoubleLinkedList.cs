namespace DoubleLinkedList
{
    public interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        IDoubleLinkedListNode<T> Next { get; set; }
        IDoubleLinkedListNode<T> Prev { get; set; }
    }

    public interface IDoubleLinkedList<T>
    {
        IDoubleLinkedListNode<T> First { get; set; }
        IDoubleLinkedListNode<T> Last { get; set; }
        int Count { get; set; }
        void Reverse();
        //insert new DoubleLinkedListNode with given value at the start of the list
        void AddFirst(T value);
        //insert new DoubleLinkedListNode with given value at the end of the list
        void AddLast(T value);
    }

    public class DoubleLinkedListNode<T> : IDoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public IDoubleLinkedListNode<T> Next { get; set; }
        public IDoubleLinkedListNode<T> Prev { get; set; }
    }

    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public IDoubleLinkedListNode<T> First { get; set; }
        public IDoubleLinkedListNode<T> Last { get; set; }
        public int Count { get; set; }

        public void AddFirst(T value)
        {
            IDoubleLinkedListNode<T> Temp = new DoubleLinkedListNode<T>() { Value = value };
            if (First != null)
            {
                Temp.Next = First;
                First.Prev = Temp;
                First = Temp;
            }
            else
            {
                Last = First = Temp;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            IDoubleLinkedListNode<T> Temp = new DoubleLinkedListNode<T>() { Value = value };
            if (Last != null)
            {
                Temp.Prev = Last;
                Last.Next = Temp;
                Last = Temp;
            }
            else
            {
                First = Last = Temp;
            }
            Count++;
        }

        public void Reverse()
        {
            IDoubleLinkedListNode<T> Temp = First;
            IDoubleLinkedListNode<T> Prev;
            IDoubleLinkedListNode<T> Next;

            if (Temp == null) return;

            Last = First;
            while (Temp != null)
            {
                Prev = Temp.Prev;
                Next = Temp.Next;

                Temp.Prev = Next;
                Temp.Next = Prev;

                First = Temp;
                Temp = Next;
            }
        }
    }
}
