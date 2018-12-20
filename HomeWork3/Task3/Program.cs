/*
 HomeWork3 by Yuliya Reshetova 
 Задача 3:
3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
x
Написать программу, демонстрирующую все разработанные элементы класса. 

** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(6, 10);
            Fraction b = new Fraction(1, 5);
            Console.WriteLine($"{a} + {b} = {a.Sum(b)}");
            Console.WriteLine($"{a} - {b} = {a.Minus(b)}");
            Console.WriteLine($"{a} * {b} = {a.Multy(b)}");
            Console.WriteLine($"{a} / {b} = {a.Div(b)}");
            Console.ReadLine();
        }
    }
}
