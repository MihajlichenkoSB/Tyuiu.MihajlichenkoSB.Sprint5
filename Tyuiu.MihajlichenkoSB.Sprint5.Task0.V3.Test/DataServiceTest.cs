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
            string path = @"C:\Users\PC\Desktop\ТИУ\repos\Tyuiu.MihajlichenkoSB.Sprint5\Tyuiu.MihajlichenkoSB.Sprint5.Task0.V3\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.IsTrue(fileExists);
        }
    }
}
