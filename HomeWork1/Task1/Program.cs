/*
 HomeWork1 by Yuliya Reshetova 
 Задача 1:
 Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
 а) используя  склеивание;
 б) используя форматированный вывод;
 в) используя вывод со знаком $.
 */

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AnswerForQuestion("Введите Ваше имя");
            string surname = AnswerForQuestion("Введите Вашу фамилию");
            string age = AnswerForQuestion("Введите Ваш возраст");
            string height = AnswerForQuestion("Введите Ваш рост в см");
            string weight = AnswerForQuestion("Введите Ваш вес в кг");

            // а) используя  склеивание;
            Console.WriteLine("Вас зовут " + surname + " " + name + "\nВаш возраст: " + age + "\nВаш рост: " + height + " см\nВаш вес: " + weight + "кг\n\n");

            // б) используя форматированный вывод;
            Console.WriteLine("Вас зовут {0} {1}\nВаш возраст: {2}\nВаш рост: {3} см\nВаш вес: {4}кг\n\n", surname, name, age, height, weight);

            // в) используя вывод со знаком $.
            Console.WriteLine($"Вас зовут {surname} {name}\nВаш возраст: {age}\nВаш рост: {height} см\nВаш вес: {weight}кг");
            Console.ReadLine();
        }


        static string AnswerForQuestion(string question){
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
