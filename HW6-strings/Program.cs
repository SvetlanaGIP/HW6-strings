using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. 
             * Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. Найти самое длинное слово в строке.*/
            Console.WriteLine("Введите предложение для поиска самого длинного слова");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string b = "";
            int a = 0;
            
            foreach (string s in stringArray)
            {
                if (s.Length > a)
                {
                    a = s.Length;
                    b = s;
                    
                }                               
                
            }
            Console.WriteLine("Самое длинное слово \"{0}\"", b);
            
            Console.ReadKey();
        }
    }
}
