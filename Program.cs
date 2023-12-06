using System;
using System.Collections.Generic; // подключение динамического массива

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // подключение рандома

            Console.Write("Введите размер массива: ");
            int sizearr = Convert.ToInt32(Console.ReadLine()); // ввод размерности массива
           
            List<int> array = new List<int>(); // объявление динамического массива

            Console.WriteLine("Исходный вариант массива:");
            for (int i = 0; i < sizearr; i++) // цикл добавление в массив рандомных чисел
            {
                array.Add(rnd.Next(100)); // добавление в массив рандомных чисел
                Console.Write(array[i] + " | "); // для более удобного восприятия информации при выводе
            }


            Console.WriteLine("\nСжатый вариант массива:");
            for (int i = 0; i < sizearr; i+=2) // цикл удаления каждого второго элемента из массива
            {
                array.Remove(i); // удаление элементов под индексом i
                Console.Write(array[i] + " | "); // для более удобного восприятия информации при выводе
            }

        }
    }
}
