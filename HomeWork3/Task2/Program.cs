/*
 HomeWork3 by Yuliya Reshetova 
 Задача 2:
а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 */

using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через enter");
            var numbers = InputNum();
            Console.WriteLine($" Сумма нечетных чисел в введеной выборке {ListToString(numbers)} = {SummOdds(numbers)}");
            Console.ReadLine();

        }

        static List<int> InputNum()
        {
            List<int> num = new List<int>();

            while (true)
            {
                int tempNum;
                if (!int.TryParse(Console.ReadLine(), out tempNum))
                {
                    Console.WriteLine("Неправильный ввод. Необходимо ввести число");
                }
                else if (tempNum != 0)
                {
                    num.Add(tempNum);
                }
                else break;
            }
            return num;
        }

        static string ListToString(List<int> numbers)
        {
            string result = "";
            foreach (var num in numbers)
            {
                result = result + num + " ";
            }
            return result;
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

