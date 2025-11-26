using Tyuiu.MihajlichenkoSB.Sprint5.Task2.V19.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] arr =
            {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            string path = ds.SaveToFileTextData(arr);

            FileInfo fi = new FileInfo(path);

            Assert.IsTrue(fi.Exists);
        }
    }
}
