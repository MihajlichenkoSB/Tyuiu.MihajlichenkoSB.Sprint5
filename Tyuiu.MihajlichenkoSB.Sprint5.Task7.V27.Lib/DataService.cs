using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string cleaned = Regex.Replace(text, @" {2,}", " ");

            string safeDir = Path.GetTempPath();

            string outputPath = Path.Combine(safeDir, "OutPutDataFileTask7V27.txt");

            File.WriteAllText(outputPath, cleaned);

            return outputPath;
        }
    }
}