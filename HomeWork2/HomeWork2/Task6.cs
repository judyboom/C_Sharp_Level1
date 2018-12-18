/*
 HomeWork2 by Yuliya Reshetova 
Задача 6. 
*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
* Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

using System;


namespace HomeWork2
{
    partial class Program
    {

        static void Task6()
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine("6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. ");
            long sumGoodNum = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (GoodNumber(i))
                {
                    sumGoodNum += i;
                }
            }
            DateTime date2 = DateTime.Now;
            Console.WriteLine($"Сумма хороших чисел = {sumGoodNum}. Вычисление заняло {date2 - date1}");


        }

        static bool GoodNumber(int num)
        {
            string numStr = num.ToString();
            int sum = 0;
            foreach (char a in numStr)
            {
                sum += Convert.ToInt32(a.ToString());
            }
            if ((num % sum) == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
