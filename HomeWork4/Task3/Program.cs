/*
 HomeWork4 by Yuliya Reshetova 
Задача 3:
Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
массив определенного размера и заполняющий массив числами от начального значения с
заданным шагом. Создать перечисление FillType которое определяет, как заполнять массив:
случайными числами или с заданным шагом. Создать свойство Sum, которое возвращает сумму
элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех
элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый
элемент массива на определённое число, свойство MaxCount, возвращающее количество
максимальных элементов.
 */

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(10, 5, 5);
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine($"Sum : {arr.Sum}");
            Console.WriteLine($"Inverse : {string.Join(" ",arr.Inverse())}");
            arr.Multy(3);
            Console.WriteLine($"Multy : {string.Join(" ", arr)}");
            Console.WriteLine($"MaxCount : {arr.MaxCount}");
            Console.ReadLine();
        }
    }
}
