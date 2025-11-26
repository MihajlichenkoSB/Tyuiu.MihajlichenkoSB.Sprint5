using Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание #4 | Вариант 3| Михайличенко С.Б.";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант: 3                                                            *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Прочитать X из файла и вычислить y по формуле.               *");
            Console.WriteLine("***************************************************************************");

            string inputPath = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

            DataService ds = new DataService();


            double x = ds.LoadFromDataFile(inputPath);


            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("X = " + x);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Готово!");
            Console.ReadKey();
        }
    }
}