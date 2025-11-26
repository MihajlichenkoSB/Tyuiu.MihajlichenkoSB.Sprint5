using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MihajlichenkoSB.Sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            using (StreamWriter writer = new StreamWriter(path))
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    string line = "";
                    for (int j = 0; j < cols; j++)
                    {
                        int value = matrix[i, j];

                        if (value % 2 != 0)
                            value = 0;

                        line += value;

                        if (j < cols - 1)
                            line += ";";
                    }
                    writer.WriteLine(line);
                }
            }

            return path;
        }
    }
}
