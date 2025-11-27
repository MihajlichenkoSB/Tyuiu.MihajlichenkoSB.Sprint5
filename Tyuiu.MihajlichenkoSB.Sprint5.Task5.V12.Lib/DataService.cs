using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double sumPositive = 0;
            double sumNegative = 0;

            foreach (string line in lines)
            {
                if (double.TryParse(line, out double value))
                {
                    value = Math.Round(value, 3);

                    if (value > 0)
                        sumPositive += value;
                    else if (value < 0)
                        sumNegative += value;
                }
            }
            return sumPositive - Math.Abs(sumNegative);
        }
    }
}
