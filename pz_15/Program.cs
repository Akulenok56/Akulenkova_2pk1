namespace pz_15;
using System;
using System.IO;


class Program
{
    static void Main()
    {
        try
        {
            string directoryPath = "C:\\Program Files";
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            Console.WriteLine("Listing directories in " + directoryPath + " sorted by decreasing length:");

            DirectoryInfo[] directories = directory.GetDirectories();
            Array.Sort(directories, (x, y) => y.Name.Length.CompareTo(x.Name.Length));

            foreach (DirectoryInfo dir in directories)
            {
                Console.WriteLine(dir.Name);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

}