/*
 HomeWork5 by Yuliya Reshetova 
 Задача 2:
Создать программу, которая будет проверять корректность ввода логина. Корректным    
логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита   
или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений; 
б) **с использованием регулярных выражений
 */
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login(Console.ReadLine());
            Console.WriteLine($"Логин {(login.IsCorrect()?"":"не ")}корректен");
            Console.WriteLine($"Логин {(login.IsCorrectRegEx()?"":"не ")}корректен");
            Console.ReadLine();
        }
    }
}
