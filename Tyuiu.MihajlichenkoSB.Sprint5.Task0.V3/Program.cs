using System;
using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Кордон К.Д | ИСТНб-24-1";
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 3;
            Console.WriteLine("Значение X = " + x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string filePath = ds.SaveToFileTextData(x);

            string resultFromFile = File.ReadAllText(filePath);

            Console.WriteLine("Полученный результат (из файла): " + resultFromFile);
            Console.WriteLine("Файл с результатом сохранен по пути: " + filePath);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
