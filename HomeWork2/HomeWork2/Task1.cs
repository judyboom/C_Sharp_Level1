/*
 HomeWork2 by Yuliya Reshetova 
 Задача 1:
Написать метод, возвращающий минимальное из трех чисел.
 */

using System;


namespace HomeWork2
{
    partial class Program
    {

        static void Task1()
        {
            int a, b, c;
            a = Convert.ToInt32(Helper.AnswerForQuestion("Задача 1: Написать метод, возвращающий минимальное из трех чисел\nВведите a:"));
            b = Convert.ToInt32(Helper.AnswerForQuestion("Введите b:"));
            c = Convert.ToInt32(Helper.AnswerForQuestion("Введите c:"));
            Console.WriteLine($"Минимальное число -> {Min(a, b, c)}");
        }

        static int Min(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
                min = a;
            else if (b < a && b < c)
                min = b;
            else
                min = c;
            return min;
        }
    }
}
