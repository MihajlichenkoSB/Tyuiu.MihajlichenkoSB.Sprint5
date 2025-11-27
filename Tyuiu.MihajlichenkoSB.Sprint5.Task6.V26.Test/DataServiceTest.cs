using Tyuiu.MihajlichenkoSB.Sprint5.Task6.V26.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = "/app/data/AssesmentData/C#/Sprint5Task6/InPutDataFileTask6V26.txt";

            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected: res, actual: res);
        }
    }
}
