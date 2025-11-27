using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Test
{
    public class DataServiceTest
    {
        public void TestCalculation()
        {
            DataService ds = new DataService();

            string path = "/app/data/AssesmentData/C#/Sprint5Task5/InPutDataFileTask5V12.txt";

            double res = ds.LoadFromDataFile(path);

            Assert.AreEqual(100.0, res);
        }
    }
}