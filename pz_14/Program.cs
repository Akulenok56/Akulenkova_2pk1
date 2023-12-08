using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите строку для поиска:");
            string searchString = Console.ReadLine();

            string filePath = "C:\\Users\\Admin\\source\\repos\\pz_14\\pz_14/textFile.txt"; // замените на путь к вашему файлу

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(searchString))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}