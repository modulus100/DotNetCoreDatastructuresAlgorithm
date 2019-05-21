using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            
            list.Append(4);
            list.Append(5);
            list.Append(6);
            
            list.Prepend(3);
            list.Prepend(2);
            list.Prepend(1);


            var node = list.Head;

            while (node.Next != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            
            Console.WriteLine(node.Value);
            
            Console.WriteLine("search for 3, result: " + list.Search(3)?.Value);
        }
    }
}