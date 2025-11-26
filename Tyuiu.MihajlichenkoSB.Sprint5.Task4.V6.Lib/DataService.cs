using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            double x = Convert.ToDouble(text);
            return x;
        }

        public double Calculate(double x)
        {
            double y = (1 / Math.Cos(x)) + 2.2 * Math.Pow(x, 2);
            return Math.Round(y, 3);
        }
    }
}
