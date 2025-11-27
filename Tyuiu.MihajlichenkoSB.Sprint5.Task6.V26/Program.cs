using Tyuiu.MihajlichenkoSB.Sprint5.Task6.V26.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Вариант 26 | Михайличенко С.Б.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Работа с файлами                                                        *");
            Console.WriteLine("* Задание 6                                                               *");
            Console.WriteLine("* Вариант 26                                                              *");
            Console.WriteLine("* Михайличенко С.Б.                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask6V26.txt");

            Console.WriteLine("Входной файл: " + path);

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество знаков вопроса: " + result);
            Console.WriteLine();
        }
    }
}