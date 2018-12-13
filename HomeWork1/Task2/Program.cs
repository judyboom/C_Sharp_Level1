/*
 HomeWork1 by Yuliya Reshetova 

 Задача 2.
 Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
 */

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = AnswerForQuestion("Введите Ваш рост в метрах");
            double weight = AnswerForQuestion("Введите Ваш вес в кг");
            Console.WriteLine($"ИМТ = {BodyMassIndex(height, weight):F}");
            Console.ReadKey();
        }

        static double AnswerForQuestion(string question)
        {
            Console.WriteLine(question);
            return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        }

        static double BodyMassIndex(double h, double w)
        {
            return w/(h*h);
        }
    }
}
