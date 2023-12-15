using System;
using System.IO;

namespace cli_fm
{
    class Program
    {
        static void Copy(string path1, string path2)
        {
            try
            {
                var fi1 = new FileInfo(path1);
                var fi2 = new FileInfo(path2);

                // Ensure that the target does not exist.
                fi2.Delete();

                // Copy the file.
                fi1.CopyTo(path2);
                Console.WriteLine($"{path1} was copied to {path2}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"The process failed: {e.ToString()}");
            }
        }
        static string[] WorkingDir()
        {
            // Skall ersättas med 
            return Directory.GetFiles(Environment.CurrentDirectory);
        }
        static void Main(string[] args)
        {
            string[] test = WorkingDir();
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }
    }
}
