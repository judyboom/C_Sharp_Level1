/*
 HomeWork2 by Yuliya Reshetova 
Задача 5:
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

using System;


namespace HomeWork2
{
    partial class Program
    {
        static void Task5()
        {
            Console.WriteLine("5. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;*Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            double weight = Convert.ToDouble(Helper.AnswerForQuestion("Введите массу"));
            double height = Convert.ToDouble(Helper.AnswerForQuestion("Введите Ваш рост в метрах").Replace(".", ","));
            double BMI = BodyMassIndex(height, weight);
            Console.WriteLine($"ИМТ = {BMI:F}");
            double weightCorrector = checkMassCorrection(BMI, height, weight);
            if (weightCorrector == 0)
            {
                Console.WriteLine("Ваш вес в норме");
            }
            else
            {
                Console.WriteLine($"Нам необходимо {((weightCorrector > 0)? "набрать":"похудеть на")} {Math.Abs(weightCorrector):F} кг");
            }
            Console.ReadKey();
        }

        static double BodyMassIndex(double h, double w)
        {
            return w / (h * h);
        }

        static double checkMassCorrection(double BMI, double h, double w)
        {
            double result;
            const double minBMI = 18.5;
            const double maxBMI = 24.99;
            if (BMI > minBMI && BMI <= maxBMI)
            {
                result = 0;
            }
            else if (BMI <= minBMI)
            {
                result = minBMI * h * h - w;
            }
            else 
            {
                result = maxBMI * h * h - w;
            }
            return result;
        }



    }
}
