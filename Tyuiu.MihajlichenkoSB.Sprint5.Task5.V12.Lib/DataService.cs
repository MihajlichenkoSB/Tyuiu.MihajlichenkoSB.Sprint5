using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double positiveSum = 0;
            double negativeSum = 0;

            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(new char[] { ' ', '\t', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string part in parts)
                {
                    if (double.TryParse(part.Replace(",", "."),
                                        NumberStyles.Any,
                                        CultureInfo.InvariantCulture,
                                        out double value))
                    {
                        if (value > 0)
                            positiveSum += value;
                        else if (value < 0)
                            negativeSum += value;
                    }
                }
            }

            double result = positiveSum - Math.Abs(negativeSum);
            return Math.Round(result, 3);
        }
    }
}