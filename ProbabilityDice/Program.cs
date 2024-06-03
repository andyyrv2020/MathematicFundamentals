namespace ProbabilityDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double one = 0;
            double two = 0;
            double three = 0;
            double four = 0;
            double five = 0;
            double six = 0;

            int count = 0;

            for (int i = 0; i < count; i++)
            {

                Random random = new Random();
                int dice = random.Next(1, 7);

                if (dice == 1)
                {
                    one++;
                }

                if (dice == 2)
                {
                    two++;
                }

                if (dice == 3)
                {
                    three++;
                }

                if (dice == 4)
                {
                    four++;
                }

                if (dice == 5)
                {
                    five++;
                }

                if (dice == 6)
                {
                    six++;
                }

            }
            Console.WriteLine("One: " + one / count);
            Console.WriteLine("Two: " + two / count);
            Console.WriteLine("Three: " + three / count);
            Console.WriteLine("Four: " + four / count);
            Console.WriteLine("Five: " + five / count);
            Console.WriteLine("Six: " + six / count);
        }
    }
}
