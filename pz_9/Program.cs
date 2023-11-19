namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = "это ваша строка"; 
            int N = 4; 

            string result = InsertStars(S, N);
            Console.WriteLine(result);
        }

        static string InsertStars(string input, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                result += input[i];
                for (int j = 0; j < count; j++)
                {
                    result += "*";
                }
            }

            result += input[input.Length - 1];

            return result;
            Console.ReadLine(); 
        }
    }
}
