using System;
using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task2.V19.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task2.V19
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

            Console.WriteLine("Введите элементы массива 3 x 3:");

            int[,] matrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("\nРЕЗУЛЬТАТ (нечётные элементы заменены на 0):");
            Console.WriteLine("---------------------------------------------");

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line.Replace(";", " | "));
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Файл сохранён в: {path}");
            Console.ReadKey();
        }
    }
}