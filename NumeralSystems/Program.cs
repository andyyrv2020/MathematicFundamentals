namespace NumeralSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please state your number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the type of your system:");
            int system = int.Parse(Console.ReadLine());
            string answer = "";

            while (x != 0)
            {
                answer = answer + x % system;
                x = x / system;
            }
            Console.WriteLine(answer.Reverse().ToArray());
        }
    }


}
