/*
 HomeWork3 by Yuliya Reshetova 
 Задача 1:
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 */
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexStruct a,b;
            a.im = 3;
            a.re = 5;
            b.im = 7;
            b.re = 6;
            Console.WriteLine("a) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.");
            Console.WriteLine($"({a.ToString()}) + ({b.ToString()}) = {a.Plus(b).ToString()}");
            Console.WriteLine($"({a.ToString()}) - ({b.ToString()}) = {a.Minus(b).ToString()}");
            Console.WriteLine($"({a.ToString()}) * ({b.ToString()}) = {a.Multi(b).ToString()}");


            ComplexClass w = new ComplexClass(3,5);
            ComplexClass v = new ComplexClass();
            v.Im = 7;
            v.Im = -5;//отрицательное не присвоится
            v.Re = 6;
            Console.WriteLine("б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.");
            Console.WriteLine($"({w.ToString()}) + ({v.ToString()}) = {w.Plus(v).ToString()}");
            Console.WriteLine($"({w.ToString()}) - ({v.ToString()}) = {w.Minus(v).ToString()}");
            Console.WriteLine($"({w.ToString()}) * ({v.ToString()}) = {w.Multi(v).ToString()}");
            Console.ReadLine();
        }
    }
}
