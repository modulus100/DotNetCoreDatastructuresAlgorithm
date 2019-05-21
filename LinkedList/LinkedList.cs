using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public void Prepend(T value)
        {
            if (Head is null)
            {
                Head = new Node<T>(value);
                return;
            }

            var tempHead = Head;
            Head = new Node<T>(value) {Next = tempHead};
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
            if (Head is null)

            {
                return null;
            }

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
    }
}