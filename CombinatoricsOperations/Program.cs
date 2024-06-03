using MathNet.Numerics;

namespace CombinatoricsOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            var y = int.Parse(Console.ReadLine());

            var permutations = Combinatorics.Permutations(x);
            Console.WriteLine($"Permutations: {permutations}");

            var combinations = Combinatorics.Combinations(x, y);
            Console.WriteLine($"Combinations: {combinations}");

            var variations = Combinatorics.Variations(x, y);
            Console.WriteLine($"Variations: {variations}");
        }
    }
}
