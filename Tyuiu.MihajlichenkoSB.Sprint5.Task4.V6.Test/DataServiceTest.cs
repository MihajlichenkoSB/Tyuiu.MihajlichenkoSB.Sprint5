using Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();

            File.WriteAllText(path, "3,5");

            DataService ds = new DataService();
            double val = ds.LoadFromDataFile(path);

            Assert.AreEqual(3.5, val);
        }
    }
}
