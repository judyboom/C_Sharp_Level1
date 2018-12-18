/*
 HomeWork2 by Yuliya Reshetova 
Задача 4:
Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
using System;


namespace HomeWork2
{
    partial class Program
    {
        static void Task4()
        {
            Console.WriteLine("4.Реализовать метод проверки логина и пароля");
            bool passAuth = false;
            int count = 0;

            do
            {
                string login = Helper.AnswerForQuestion("Введите логин");
                string pass = Helper.AnswerForQuestion("Введите пароль");
                passAuth = CheckAuth(login, pass);
                Console.WriteLine($"Пароль {(passAuth? "верен":"не верен")} {(count != 2 && !passAuth? "Повторите ввод" : "")} ");

                count++;

            } while (!(count == 3 || passAuth));

        }

        static bool CheckAuth(string login, string pass)
        {
            return ((login == "root" && pass == "GeekBrains")? true:false);  
        } 
    }
}
