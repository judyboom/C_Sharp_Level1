/*
 HomeWork5 by Yuliya Reshetova 
 Задача 1:
 Написать статический метод void CreateCharsFile(string filename, int start, int finish), который   
 создает файл содержащий символы из заданного диапазона (от start до finish). Обработать корректно  
 исключения связанные с невозможностью создания файла. 
 */
using System;
using System.Collections.Generic;
using System.IO;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCharsFile("test.txt", 97, 100);
            Console.ReadLine();
        }

        static void CreateCharsFile(string filename, int start, int finish)
        {
            List<string> textChar = new List<string>();
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
                textChar.Add(Convert.ToChar(i).ToString());
            }
            try
            {
                File.WriteAllLines(filename, textChar.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
