/*
 HomeWork2 by Yuliya Reshetova 
Задача 3:
С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

using System;
using System.Collections.Generic;


namespace HomeWork2
{
    partial class Program
    {
        static void Task3()
        {
            Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n Введите числа:\n");
            List<int> num = new List<int>();

            while (true)
            {
                int tempNum = Convert.ToInt32(Console.ReadLine());
                if (tempNum != 0)
                {
                    num.Add(tempNum);
                }
                else break;
            }
            Console.WriteLine($" Сумма нечетных чисел в введеной выборке = {SummOdds(num)}");
           
        }

        static int SummOdds(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0 && number > 0)
                    sum += number;
            }
            return sum;
        }




    }
}
