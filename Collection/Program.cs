using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}


