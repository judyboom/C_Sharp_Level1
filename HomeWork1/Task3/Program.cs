/*
 HomeWork1 by Yuliya Reshetova 

 Задача 3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 */

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            var x1 = AnswerForQuestion("Введите x1");
            var y1 = AnswerForQuestion("Введите y1");
            var x2 = AnswerForQuestion("Введите x2");
            var y2 = AnswerForQuestion("Введите y2");

            //a)
            Console.WriteLine($"Расстояние между точек {{{x1};{y1}}} и {{{x2};{y2}}} равно {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)):F}");

            //b)
            Console.WriteLine($"Расстояние между точек {{{x1};{y1}}} и {{{x2};{y2}}} равно {Distance(x1, y1, x2, y2):F}");
            Console.ReadLine();
        }


        static double Distance(int x1, int y1, int x2, int y2) {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static int AnswerForQuestion(string question)
        {
            Console.WriteLine(question);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
