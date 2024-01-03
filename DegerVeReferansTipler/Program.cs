using System;

namespace DegerVeReferansTipler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] {100, 200, 300 };
            sayilar1 = sayilar2;
            foreach (int i in sayilar1)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}