/*
 HomeWork1 by Yuliya Reshetova 
 Задача 5:
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
 */

using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Юлия Решетова г.Калуга";
            Console.WriteLine(text);
            Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth/2 - text.Length/2, Console.WindowHeight/2);
            Console.WriteLine(text);
            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();

            Print(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2, text);
        }


        static void Print(int x, int y, string text) {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
            Console.ReadLine();
        }

    }
}
