using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFile()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);
            string expectedValue = "-1.000"; 

            Assert.AreEqual(expectedValue, fileContent);

        }
    }
}
