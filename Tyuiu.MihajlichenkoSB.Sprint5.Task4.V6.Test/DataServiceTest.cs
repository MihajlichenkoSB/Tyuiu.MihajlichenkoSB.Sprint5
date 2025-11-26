using Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double result = ds.Calculate(x);

            double expected = Math.Round((1 / Math.Cos(2)) + 2.2 * Math.Pow(2, 2), 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLoadFromFile()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "3,5");

            DataService ds = new DataService();
            double val = ds.LoadFromDataFile(path);

            Assert.AreEqual(3.5, val);
        }
    }
}
