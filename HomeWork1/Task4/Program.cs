/*
 HomeWork1 by Yuliya Reshetova 

 Задача 4.
 Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
 */

using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = AnswerForQuestion("Введите переменную a");
            var b = AnswerForQuestion("Введите переменную b");
            Console.WriteLine($"a = {a} b = {b}");
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a} b = {b}");

            a = String.Concat(a, b);
            b = a.Remove(a.Length - b.Length);
            a = a.Remove(0, b.Length);
            Console.WriteLine($"a = {a} b = {b}");

            Console.ReadLine();
        }

        static string AnswerForQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
