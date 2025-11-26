using System;
using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task1.V26.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Михайличенко С.Б. | Вариант 26";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Работа с файлами                                                   *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович                                  *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("ТАБЛИЦА ЗНАЧЕНИЙ ФУНКЦИИ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("   x      f(x)");
            Console.WriteLine("---------------------------------");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                Console.WriteLine($"{parts[0],4} {parts[1],8}");
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Файл сохранён: {path}");
            Console.ReadKey();
        }
    }
}