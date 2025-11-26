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
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Табулировать функцию                                                     *");
            Console.WriteLine("*   F(x) = (2x + 6) / (cos(x) + x) – 3                                      *");
            Console.WriteLine("* на промежутке [-5, 5] с шагом 1.                                         *");
            Console.WriteLine("* Проверить деление на ноль. При делении — вернуть 0.                     *");
            Console.WriteLine("* Результат сохранить в файл и вывести в таблицу.                          *");
            Console.WriteLine("* Округление до двух знаков.                                               *");
            Console.WriteLine("****************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            string[] yValues = File.ReadAllLines(path);

            Console.WriteLine("\nТАБЛИЦА ЗНАЧЕНИЙ ФУНКЦИИ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("   x        f(x)");
            Console.WriteLine("---------------------------------");

            int x = startValue;
            foreach (string y in yValues)
            {
                Console.WriteLine($"{x,4} {y,10}");
                x++;
            }

            Console.WriteLine("---------------------------------\n");
            Console.WriteLine($"Файл успешно сохранён:\n{path}");

            Console.ReadKey();
        }
    }
}