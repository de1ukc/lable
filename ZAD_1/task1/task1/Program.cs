using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Microsoft.Win32;

namespace task1
{ 
    class Program
    {   public static string Number(string item)
        {
            if (item.All(i => i <= '9' && i >= '.' && i != '/')) return item;
            Console.WriteLine("It is not a number, your symbol will be replaced with 0.Now the answer is not correct.Try again laser brain!!!");
            Environment.Exit(0);
            return "0";
        }
        static long binpow(long a, long n)
        {
            long res = 1;
            while (n > 0)
            {
                if (n % 2 == 1) res = res * a;
                a *= a;
                n /= 2;
            }
            return res;
        } 
        static long res(long a) { 
            long stepen = 0;
            if (a == 0) return 0;
            for (long i = 1; i < 64; i++)
              {
                stepen += a/binpow(2, i);
              }
            return stepen;
        }
        static void Main(string[] args)
        {   Console.WriteLine("Введите число a :");
            long a = long.Parse(Number(Console.ReadLine()));
            Console.WriteLine("Введите число b :");
            long b = long.Parse(Number(Console.ReadLine()));
            long ans = 0;
            if (b > a) { ans = res(b) - res (a-1) ; }
           else
           {
               if (a > b) {  ans = res(a) - res (b-1) ; }
               if (a==b) { Console.WriteLine("You've entered the same numbers.You are a bold one "); }
           }
            Console.WriteLine($"Максимальная степень двойки равна {ans}");
        }
    }
} 