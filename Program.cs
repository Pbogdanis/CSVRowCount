using System;
using System.IO;
using System.Linq;

namespace CSVRowCount
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.csv"))
            {
                Console.WriteLine("FileName: " + file.Name + " Row COUNT: " + File.ReadLines(file.FullName).Count());
                DateTime end = DateTime.Now;
                TimeSpan ellapsed = end - start;
                Console.WriteLine(ellapsed.ToString("c"));
            }
        }
    }
}
