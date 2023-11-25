namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это первое предложение. Это второе предложение!";

            int firstPeriodIndex = text.IndexOf('.');
            int lastPeriodIndex = text.LastIndexOf('.');

            if (firstPeriodIndex != -1 && lastPeriodIndex != -1)
            {
                string firstSentence = text.Substring(0, firstPeriodIndex + 1);
                string lastSentence = text.Substring(lastPeriodIndex + 1);
                string middleText = text.Substring(firstPeriodIndex + 1, lastPeriodIndex - firstPeriodIndex);

                string newText = lastSentence + middleText + firstSentence;
                Console.WriteLine(newText);
            }
            else
            {
                Console.WriteLine("Текст не содержит предложений.");
            }
        }
    }
}
    

