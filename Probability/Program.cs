namespace Probability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heads = 0;
            double tails = 0;
            int count = 1000000;

            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int coin = random.Next(1, 3);

                if (coin == 1)
                {
                    heads++;
                }

                if (coin == 2)
                {
                    tails++;
                }
            }
            Console.WriteLine("Heads: " + heads / count);
            Console.WriteLine("Tails: " + tails / count);
        }
    }
}
