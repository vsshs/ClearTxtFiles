using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTxtFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(dir);

            var dirInfo = new DirectoryInfo(dir);

            var files = dirInfo.GetFiles("*.txt");

            foreach (var fileInfo in files)
            {
                try
                {
                    Console.WriteLine("Clearing: " + fileInfo.Name);
                    System.IO.File.WriteAllText(fileInfo.FullName, string.Empty);
                }
                catch (Exception e)
                {
                    Console.WriteLine("   ERROR: " + e.Message);
                }

            }
        }
    }
}
