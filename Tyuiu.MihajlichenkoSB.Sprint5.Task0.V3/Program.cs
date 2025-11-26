using Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Кордон К.Д | ИСТНб-24-1";
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение X = " + x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine(" файл " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
