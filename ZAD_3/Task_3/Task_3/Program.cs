using System;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace Task_3
{
    class Program
    {
        public static string Text(string item)
        {
            if (item.All(i => ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z') || i == ' '))) return item;
            Console.WriteLine("In your string there is words with numbers.It's uncorrect.Or are you using non-English symbols.This is forbidden.Try Again!!!");
            return "0";
        }
        static void Main(string[] args)
        {  
            string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVQXYZA";
            string alphabet = ALPHABET.ToLower();
            string glasn = "aeijouy";
            string[] a = Text(Console.ReadLine()).Split();
            string[] ans = new string[a.Length]; // конечная строка с исправленными буквами 
             for(int k = 0; k < a.Length; k++)
            {
                string word = a[k]; // копирую каждое слово в новую строку
                ans[k] = ""; // чищу слово в ответe
                for (int i = 0; i < word.Length; i++) // всё в циклах - работа с каждой буквой в отдельности
                {
                    if (i + 1 == word.Length)
                    {
                        ans[k] = string.Concat(ans[k], (word[i]));
                        break;
                    }
                    bool good = false;
                    for(int j = 0; j < glasn.Length; j++)
                        if (word[i] == glasn[j])
                        {
                            good = true;
                            break;
                        }
                    if (good)
                    { 
                        ans[k] = string.Concat(ans[k],  word[i]); // сую гласную 
                        ans[k] = string.Concat(ans[k], alphabet[alphabet.IndexOf(word[i + 1]) + 1]); // меняю следующую за гласной
                        i++;
                    }
                    else
                    {
                        ans[k] = string.Concat(ans[k], (word[i])); // оставляю всё прежним
                    }
                }
                foreach (var c in ans[k])
                {
                    Console.Write(c);
                }
                Console.Write(" ");
            }
        }
        }
    }

