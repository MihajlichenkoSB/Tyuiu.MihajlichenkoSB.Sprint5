using System;
using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Вариант 12 | Михайличенко С.Б.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Работа с файлами                                                         *");
            Console.WriteLine("* Задание 5                                                                *");
            Console.WriteLine("* Вариант 12                                                               *");
            Console.WriteLine("* Михайличенко С.Б.                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string inputPath = @"C:\DataSprint5\InPutDataFileTask5V12.txt";

            Console.WriteLine("Входной файл: " + inputPath);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(inputPath);

            Console.WriteLine("Результат вычисления: " + result);
            Console.WriteLine();
        }
    }
}