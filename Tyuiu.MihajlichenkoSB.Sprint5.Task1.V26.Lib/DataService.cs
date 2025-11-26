using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = Math.Cos(x) + x;
                    double y;

                    if (Math.Abs(denominator) < 1e-7)
                        y = 0;
                    else
                        y = (2 * x + 6) / denominator - 3;

                    y = Math.Round(y, 2);

                    // ✔️ ПИШЕМ ТОЛЬКО y — без x
                    writer.WriteLine($"{y}");
                }
            }

            return path;
        }
    }
}