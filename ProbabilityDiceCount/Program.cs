namespace ProbabilityDiceCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                count++;
                Random random = new Random();

                int dice = random.Next(1, 7);

                if (dice == 6)
                {
                    count++;
                    break;
                }
            }

            Console.WriteLine("Count: " + count);
        }
    }
}
