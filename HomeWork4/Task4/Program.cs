/*
 HomeWork4 by Yuliya Reshetova 
Задача 4:
Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
Создайте структуру Account, содержащую Login и Password. Использовать StreamReader.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool passAuth = false;
            int count = 0;

            do
            {

                string login = Helper.AnswerForQuestion("Введите логин");
                string pass = Helper.AnswerForQuestion("Введите пароль");
                passAuth = CheckAuth(login, pass);
                Console.WriteLine($"Пароль {(passAuth ? "верен" : "не верен")} {(count != 2 && !passAuth ? "Повторите ввод" : "")} ");
                Console.ReadLine();
                count++;

            } while (!(count == 3 || passAuth));
        }

        static bool CheckAuth(string login, string pass)
        {
            List<Account> rightDataAuth = GetAccountList("Auth.txt");
            foreach (var i in rightDataAuth)
            {
                if (i.Login == login && i.PassWord == pass)
                {
                    return true;
                }
            }
            return false;
        }

        static List<Account> GetAccountList(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string login;
            string password;
            var result = new List<Account>();
            while ((login = sr.ReadLine()) != null && (password = sr.ReadLine()) != null)
            {
                result.Add(new Account(login, password));
            }
            return result;
        }
    }
}
