namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив nums[4, 5] и заполняем его случайными целыми числами
            int[,] nums = new int[4, 5];
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    nums[i, j] = random.Next(1, 100); // Генерируем случайное число от 1 до 99
                }
            }

            // Создаем одномерный массив для хранения максимальных значений столбцов
            int[] maxValues = new int[5];

            // Находим максимальные значения для каждого столбца
            for (int j = 0; j < 5; j++)
            {
                int max = nums[0, j];

                for (int i = 1; i < 4; i++)
                {
                    if (nums[i, j] > max)
                    {
                        max = nums[i, j];
                    }
                }

                maxValues[j] = max;
            }

            // Выводим максимальные значения столбцов
            Console.WriteLine("Максимальные значения столбцов:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Столбец {j + 1}: {maxValues[j]}");
            }
        }
    }
}