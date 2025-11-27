using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            int positiveSum = 0;
            int negativeSum = 0;

            foreach (string line in File.ReadAllLines(path))
            {
                // Учитываем только целые числа!
                if (int.TryParse(line, out int value))
                {
                    if (value > 0)
                        positiveSum += value;
                    else if (value < 0)
                        negativeSum += value;
                }
                // Все дробные строки пропускаем
            }

            double result = positiveSum - Math.Abs(negativeSum);
            return Math.Round(result, 3);
        }
    }
}