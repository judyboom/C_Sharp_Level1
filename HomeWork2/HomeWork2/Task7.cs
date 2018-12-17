/*
 HomeWork2 by Yuliya Reshetova 
Задача 7:
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

 */
using System;


namespace HomeWork2
{
    partial class Program
    {
        static void Task7()
        {
            Console.WriteLine("a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b)");
            int a1 = Convert.ToInt32(Helper.AnswerForQuestion("Введите a1"));
            int b1 = Convert.ToInt32(Helper.AnswerForQuestion("Введите b1"));
            Console.WriteLine(Numbers(a1, b1));
            Console.WriteLine("б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");
            int a2 = Convert.ToInt32(Helper.AnswerForQuestion("Введите a2"));
            int b2 = Convert.ToInt32(Helper.AnswerForQuestion("Введите b2"));
            Console.WriteLine(SumOfNumbers(a2, b2));
            Console.WriteLine($"Сумма чисел от {a2} до {b2} = {SumOfNumbers(a2, b2)}");
        }

        static string Numbers(int a, int b)
        {
            if (a == b)
            {
                return a.ToString();
            }
            return a + " " + Numbers(a+1, b);
        }

        static int SumOfNumbers(int a, int b)
        {
            if (a > b)
            {
                if (a == b)
                {
                    return a;
                }
                return a + SumOfNumbers(a - 1, b);
            }
            else
            {
                if (a == b)
                {
                    return a;
                }
                return a + SumOfNumbers(a + 1, b);
            }
        }

    }
}
