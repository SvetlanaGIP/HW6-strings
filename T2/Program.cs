using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. 
             * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра 
             * (пример палиндрома – «А роза упала на лапу Азора»).*/
             Console.WriteLine("Введите предложение для проверки на палиндромность");
            string startString = Console.ReadLine();            
            string[] stringArray = startString.Split();
            string resultString = "";
            string newString = "";
            resultString = startString.Replace(" ", "").ToLower();
            /*foreach (string s in stringArray) //вариант удаления пробелов через разбивку на слова
            {

                resultString += s.Substring(0, 1).ToLower().Trim()  + s.Substring(1);
            }*/
            //Console.WriteLine(resultString);

            for (int i = 0; i < resultString.Length; i++)
            {
                newString = resultString[i] + newString;
            }
             // Console.WriteLine(resultString); 
            if (newString==resultString) // это если составляем предложение наоборот
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение НЕ является палиндромом");
            }


            Console.ReadKey();
/* foreach (object p in resultString)
             {                
                 Console.WriteLine(p); // проверка, что все символы читаются отдельно  
             } */
            /*for (int i = 0; i < n/2; i++,n--) // в этом варианте пытаюсь сравнивать первую и последнюю буквы
            {
               if (i == n)
               {
                   i++;
                   n--; 
                   Console.WriteLine("Предложение является палиндромом");
               }

                else
               {
                   Console.WriteLine("Предложение НЕ является палиндромом");
               }
           }*/
        }
    }
}
