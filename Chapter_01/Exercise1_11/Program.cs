using System;
using System.IO;
using System.Threading.Tasks;
namespace Exercise1_11
{
    class Program
    {
        public static async Task Main()
        {
            using (var fileStream = new FileStream("Products.csv", FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    var content = await reader.ReadToEndAsync();
                    var lines = content.Split(Environment.NewLine);
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}