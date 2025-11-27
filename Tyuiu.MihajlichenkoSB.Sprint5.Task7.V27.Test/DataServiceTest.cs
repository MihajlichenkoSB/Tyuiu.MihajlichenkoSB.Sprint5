using Tyuiu.MihajlichenkoSB.Sprint5.Task7.V27.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task7.V27.Test
{
    public class DataServiceTest
    {
        public void TestLoadDataAndSave()
        {
            DataService ds = new DataService();

            // создаём временный входной файл
            string tempDir = Path.GetTempPath();
            string inputPath = Path.Combine(tempDir, "InPutDataFileTask7V27.txt");

            File.WriteAllText(inputPath, "Привет   мир    !!!");

            // вызов метода
            string outputPath = ds.LoadDataAndSave(inputPath);

            // проверяем файл
            string result = File.ReadAllText(outputPath);

            Assert.AreEqual("Привет мир !!!", result);
        }
    }
}