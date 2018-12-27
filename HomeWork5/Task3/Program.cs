/*
 HomeWork5 by Yuliya Reshetova 
 Задача 3:
 Разработать статический класс ​Message​, содержащий следующие статические методы для      
 обработки текста: 
 а) Вывести только те слова сообщения,  которые содержат не более n букв. 
 б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 в) Найти самое длинное слово сообщения. 
 г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. 
 д) ***Создать метод, который производит частотный анализ текста. 
 В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает
 сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary. 
 е) *Использовать коллекции List<string>; 
 
 */
using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes = "Мама мыла раму, но никогда не красила ногти потому что ей не нравилась краска";
            Console.WriteLine(Message.GetWordsLessNLetters(mes, 5));
            Console.WriteLine(Message.DeleteWordsEndWithS(ref mes,'ь'));
            Console.WriteLine(mes);
            Console.WriteLine(Message.GetMaxLenthWord(mes));
            Console.WriteLine(Message.GetMaxLenthWords(mes));
            Console.WriteLine(Message.GetMaxLenthWordsStrBuilder(mes));
            List<string> mesList = new List<string>
            {
                "мыла",
                "не",
                "красила"
            };
            Dictionary<string, int> Dic = Message.FrequencyDic(mesList, mes);
            Console.WriteLine(string.Join(" ", Dic.Keys));
            Console.WriteLine(string.Join(" ", Dic.Values));
            Console.ReadLine();
        }
    }
}
