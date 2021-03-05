using System;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bufer;
            bufer = Console.ReadLine().Split();
            Array.Reverse(bufer);
            for (int i = 0; i < bufer.Length; i++)
            {
                Console.Write(bufer[i] + " "); 
            }
        }
    }
}