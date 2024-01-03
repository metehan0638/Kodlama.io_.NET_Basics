using GenericsIntro;
using System;

namespace Matematik // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyList<string> myList = new MyList<string>(); 
            myList.Add("a");
        }
    }
}