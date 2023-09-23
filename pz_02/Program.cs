using System.ComponentModel.Design;

namespace pz_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную b");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = 0.0;
            double y = 0.0;
            double z = 0.0;
            if (a > 3)//обработка первого условия первой системы
            {
                x = 2 * a;
            }
            else if (a <= 3)//обработка второго условия первой системы
            {
                x = (6 * (b + 8)) / (a - 2);
            }
            if (x <= 10)//обработка первого условия второй системы
            {
                y = Math.Sin(a * x);
            }
            else if (x > 10)//обработка второго условия второй системы
            {
                y = Math.Cos(b * x) / a;
            }
            z = 2 * x * y - Math.Pow(y, 2);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("x=" + x);
            Console.WriteLine("z=" + z);
        }
    }          
}