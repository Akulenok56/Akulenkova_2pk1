namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10]; // Создаем массив из 10 элементов
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    numbers[i] = inputNumber;
                    sum += inputNumber;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Введите целое число.");
                    i--; // Уменьшаем счетчик, чтобы запросить ввод снова
                }
            }

            Console.WriteLine($"Сумма введенных чисел: {sum}");
        }
    }
}