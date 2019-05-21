using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public int Size
        {
            get
            {
                var size = 0;
                if (Head is null) return size;

                var node = Head;

                while (node != null)
                {
                    size++;
                    node = node.Next;
                }

                return size;
            }
        }

        public void Prepend(T value)
        {
            if (Head is null)
            {
                Head = new Node<T>(value);
                return;
            }

            var tempHead = Head;
            Head = new Node<T>(value)
            {
                Next = tempHead
            };
        }

        public void Append(T value)
        {
            if (Head is null)
            {
                Head = new Node<T>(value);
                return;
            }

            var node = Head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = new Node<T>(value);
        }

        public Node<T> Search(T value)
        {
            if (Head is null) return null;

            var node = Head;

            while (node != null)
            {
                if (Comparer<T>.Default.Compare(node.Value, value) >= 0)
                {
                    return node;
                }

                node = node.Next;
            }

            return null;
        }

        public void Remove(T value)
        {
            if (Head is null) return;

            if (Comparer<T>.Default.Compare(Head.Value, value) >= 0)
            {
                Head = Head.Next;
                return;
            }

            var node = Head;

            while (node.Next != null)
            {
                if (Comparer<T>.Default.Compare(node.Next.Value, value) >= 0)
                {
                    node.Next = node.Next.Next;
                    return;
                }

                node = node.Next;
            }
        }
        
        public T Pop()
        {
            if (Head is null) return default(T);

            T value = Head.Value;
            Head = Head.Next;
            return value;
        }

        public void Insert(T value, int pos)
        {
            var index = 1;
            
            if (pos < 0) return;

            if (Head is null)
            {
                Head = new Node<T>(value);
                return;
            }

            if (pos == 0)
            {
                Prepend(value);
                return;
            }

            var node = Head;

            while (node.Next != null)
            {
                if (index == pos)
                {
                    node.Next = new Node<T>(value)
                    {
                        Next = node.Next
                    };
                    
                    return;
                }

                node = node.Next;
                index++;
            }
            
            node.Next = new Node<T>(value);
        }

        public List<T> ToList()
        {
            var list = new List<T>();
            if (Head is null) return list;

            var node = Head;

            while (node != null)
            {
                list.Add(node.Value);
                node = node.Next;
            }

            return list;
        }
    }
}