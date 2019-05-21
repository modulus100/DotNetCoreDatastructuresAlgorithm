using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Append(6);
            
            linkedList.Prepend(3);
            linkedList.Prepend(2);
            linkedList.Prepend(1);


            foreach (var value in linkedList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("search for 3, result: " + linkedList.Search(3)?.Value);
        }
    }
}