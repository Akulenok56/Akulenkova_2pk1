namespace pz_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            bool p = a >= 1 && a < 6 ? true : false;
            int result = 0;
            switch (p)
            {
                case true:
                    result = sum - (sum / 100 * 5);
                    Console.WriteLine("Скидка составляет 5%");
                    break;
                case false:
                    result = sum - (sum / 100 * 10);
                    Console.WriteLine("Скидка составляет 10%");
                    break;
            }
            Console.WriteLine("Сумма со скидкой + result");
        }
    }

}