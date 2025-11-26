using Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(path));

            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double value = br.ReadDouble();
                Assert.AreEqual((Math.Round((Math.Pow(3, 2) + 1) / (3 * 3 + 4), 3)), value);
            }
    }
}
