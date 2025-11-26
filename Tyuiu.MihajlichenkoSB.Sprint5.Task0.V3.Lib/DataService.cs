using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
            double y = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);

            y = Math.Round(y, 3, MidpointRounding.AwayFromZero);

            string resultStr = y.ToString("0.000", CultureInfo.InvariantCulture);

            string fileName = "OutPutFileTask0.txt";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            File.WriteAllText(filePath, resultStr);

            return filePath;
        }
    }
}
