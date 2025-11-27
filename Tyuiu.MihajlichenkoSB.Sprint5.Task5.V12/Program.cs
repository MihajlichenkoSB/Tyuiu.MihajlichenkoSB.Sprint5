using Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание #5 | Вариант #12 | Выполнил: Михайличенко С.Б.";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Чтение данных из файла                                              ");
            Console.WriteLine("* Задание #5                                                                ");
            Console.WriteLine("* Вариант #12                                                               ");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович, группа ИИПб-25-1                ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  ");
            Console.WriteLine("* Дано: Файл содержит набор значений. Найти разницу между суммой           ");
            Console.WriteLine("* положительных и отрицательных чисел.                                     ");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V12.txt";

            DataService ds = new DataService();

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат вычисления: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}