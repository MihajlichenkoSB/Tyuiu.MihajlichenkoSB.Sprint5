using System;
using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = 3;

            Console.Title = "Спринт #5 | Task 3 | Михайличенко С.Б. | Вариант 26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание 3                                                               *");
            Console.WriteLine("* Вариант 26                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение. Вычислить его значение при x = 3.                       *");
            Console.WriteLine("* Сохранить результат в бинарный файл OutPutFileTask3.bin                *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData((int)x);

            Console.WriteLine("\nРезультат сохранён в файл:");
            Console.WriteLine(path);

            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double value = br.ReadDouble();
                Console.WriteLine($"\nПрочитанное значение: {value}");
            }

            Console.ReadKey();
        }
    }
}