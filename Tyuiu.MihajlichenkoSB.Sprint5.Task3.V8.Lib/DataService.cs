using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                bw.Write(y);
            }

            return path;
        }
    }
}
