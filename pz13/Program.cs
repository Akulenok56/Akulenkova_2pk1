namespace pz13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double ArithmeticProgression(double a1, double d, int n)
            {
                if (n == 1)
                {
                    return a1;
                }
                else
                {
                    return ArithmeticProgression(a1, d, n - 1) + d;
                }
            }

            static void Main()
            {
                double a1 = -5;
                double d = -0.5;
                int n = 10;

                double n_th_term = ArithmeticProgression(a1, d, n);
                Console.WriteLine("n-й член арифметической прогрессии: " + n_th_term);

                // 2 задание 
                static double GeometricProgression(double a1, double q, int n)
                {
                    if (n == 1)
                    {
                        return a1;
                    }
                    else
                    {
                        return GeometricProgression(a1, q, n - 1) * q;
                    }
                }

                static void Main()
                {
                    double a1 = 1;
                    double q = 0.4;
                    int n = 5;

                    double n_th_term = GeometricProgression(a1, q, n);
                    Console.WriteLine("n-й член геометрической прогрессии: " + n_th_term);
                }

                // 3 задание
                static void PrintNumbers(int start, int end)
                {
                    if (start <= end)
                    {
                        Console.WriteLine(start);
                        PrintNumbers(start + 1, end);
                    }
                }

                static void PrintNumbersDescending(int start, int end)
                {
                    if (start >= end)
                    {
                        Console.WriteLine(start);
                        PrintNumbersDescending(start - 1, end);
                    }
                }

                static void Main()
                {
                    int num1 = -10;
                    int num2 = 100;

                    if (num1 < num2)
                    {
                        PrintNumbers(num1, num2);
                    }
                    else
                    {
                        PrintNumbersDescending(num1, num2);



                    }
                }
            }
        }
    }
}
