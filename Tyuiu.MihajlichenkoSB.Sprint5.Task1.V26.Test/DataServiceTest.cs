using Tyuiu.MihajlichenkoSB.Sprint5.Task1.V26.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFileCreated()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);

            Assert.IsTrue(fileInfo.Exists);
        }
    }
}