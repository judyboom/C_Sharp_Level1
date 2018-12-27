/*
 HomeWork5 by Yuliya Reshetova 
 Задача 4:
 *Для двух строк написать метод, определяющий, 
 * является ли одна строка перестановкой           
 * другой. Например: badc​ являются перестановкой ​abcd​. 
 */
using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "asdflk";
            string str2 = "asfkld";
            string str3 = "Hello";
            Console.WriteLine($"Строка {str1} {(CheckTransposition(str1,str2)?"":"не ")} является перестановкой строки {str2} ");
            Console.WriteLine($"Строка {str1} {(CheckTransposition(str1,str3)?"":"не ")} является перестановкой строки {str3} ");
            Console.ReadLine();
        }

        static bool CheckTransposition(string a, string b)
        {
            return string.Join("",a.OrderBy(c => c)) == string.Join("",b.OrderBy(d => d));
        }
    }
}
