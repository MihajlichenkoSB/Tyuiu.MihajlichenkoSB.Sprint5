using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Trim();

            double x = double.Parse(text, CultureInfo.InvariantCulture);

            double y = 1 / Math.Cos(x) + 2.2 * Math.Pow(x, 2);

            return Math.Round(y, 3);
        }
    }
}