using System.ComponentModel.Design;

namespace pz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num = Convert.ToInt32(Console.ReadLine());
          string[] massive = PrintArray(num);
          foreach(string i in massive)
          {
                Console.WriteLine(i);
          }
        }
        static string[] PrintArray(int a)
        {
            string[]nums = new string[a];
            string stroka = "";
            for(int i = 0; i < a; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        stroka += "*";
                    }
                }
                else if ((i + 1) % 2 != 0)
                {
                    for(int j = 0;j <= i; j++)
                    {
                        if (j == (i + 1) / 2 && j != 0)
                        {
                            stroka += ".";
                        }
                    }
                }
                nums[i] = stroka;
                stroka = "";
            } 
            return nums;
            
        }
    }
}
