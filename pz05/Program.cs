namespace pz05
 class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        while (i * i <= n)
        {
            Console.Write(i * i + " ");
            i++;
        }
    }
}