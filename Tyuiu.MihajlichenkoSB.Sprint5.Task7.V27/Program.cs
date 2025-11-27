using Tyuiu.MihajlichenkoSB.Sprint5.Task7.V27.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Title = "Спринт #5 | Задание 7 | Вариант 27 | Михайличенко С.Б.";

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #5                                                *");
            Console.WriteLine("* Работа с файлами                                         *");
            Console.WriteLine("* Задание 7                                                *");
            Console.WriteLine("* Вариант 27                                               *");
            Console.WriteLine("* Михайличенко С.Б.                                        *");
            Console.WriteLine("************************************************************");
            Console.WriteLine();

            string inputPath = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask7V27.txt");

            Console.WriteLine("Входной файл: " + inputPath);

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine("Результат сохранён в файл:");
            Console.WriteLine(outputPath);
            Console.WriteLine();
        }
    }
}