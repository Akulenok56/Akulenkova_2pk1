namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводим переменную а");
            double a = double.Parse (Console.ReadLine());

            Console.WriteLine("Вводим переменную b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Вводим переменную c");
            double c = double.Parse(Console.ReadLine());

            double num1 = Math.Cos(a + 2*c) / 0.5 * Math.Abs(c);
            double num2 = Math.Sqrt(a - c) * Math.Tan(b / 3 * a);
            double num3 = Math.Abs(Math.Log(2, a) - (Math.Pow(4 * a, 1 / 3))); ;

        }
    }
}