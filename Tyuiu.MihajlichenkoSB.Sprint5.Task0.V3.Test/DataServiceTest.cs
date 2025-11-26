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

            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);

            Assert.IsTrue(fileInfo.Exists);
        }
    }
}