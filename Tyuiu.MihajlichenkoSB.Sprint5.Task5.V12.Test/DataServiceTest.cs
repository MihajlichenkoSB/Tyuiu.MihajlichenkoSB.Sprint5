using Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "TestTask5V12.txt");

            File.WriteAllLines(path, new string[]
            {
                "5",
                "-2",
                "3.456",
                "-1.789",
                "7"
            });

            DataService ds = new DataService();

            double result = ds.LoadFromDataFile(path);

            double expected = 11.667;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
