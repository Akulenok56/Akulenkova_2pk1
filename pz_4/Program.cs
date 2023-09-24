using Microsoft.Win32.SafeHandles;

namespace pz_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Число от 0 до 100 сс шагом 2");
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();


            //задание 2
            Console.WriteLine("5 символов в алфавитном порядке, начиная с A");
            for (char i = 'A'; i <= 'F'; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();


            //задание 3
            Console.WriteLine("3 # значков в 5 строках");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine('#');
            }
            Console.WriteLine();


            //задание 4
            int count = 0;
            Console.WriteLine("значение от -100 до 0, кратное 3");
            for (int i = -100; i <= 0; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + "");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("количество чисел кратных'3' равно " + count);
            Console.WriteLine();


            //задание 5
            Console.WriteLine("задание 5");
            int a, b;
            for (a = 1, b = 40; b - a > 10; a++, b--)
            {
                Console.WriteLine(a + "" + b);
            }
            Console.WriteLine(a + "+b");


        }
    }
}