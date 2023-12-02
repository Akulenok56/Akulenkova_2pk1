namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 0;
            double s = 0;
            double r = 0;
            Console.Write("введите длину первого катета: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("введите длину второго катета: ");
            int b = int.Parse(Console.ReadLine());
            gip(a, b, c);
            ploshad(a, b, s);
            radius(a, b, c, r);
        }


        static void gip(int a, int b, double c)
        {
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("длинна гипотенузы: " + c);
        }


        static void ploshad(int a, int b, double s)
        {
            s = 0.5 * (a * b);
            Console.WriteLine("площадь:" + s);
        }


        static void radius(int a, int b, double c, double r)
        {
            r = (a + b - c) / 2;
            Console.WriteLine("радиус" + r);
        }



    }
}
