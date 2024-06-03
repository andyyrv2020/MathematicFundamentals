namespace ListsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 1, 2, 3 };
            List<int> B = new List<int> { 2, 3, 4 };
            Console.WriteLine($"1.Обединение ");
            DisplaySet(A.Union(B));
            Console.WriteLine($"2.Сечение ");
            DisplaySet(A.Intersect(B));
            Console.WriteLine($"3.Разлика ");
            DisplaySet(A.Except(B));
            Console.WriteLine($"4.Сбор ");
            DisplaySet(A.Concat(B).ToHashSet());
        }
        static void
            DisplaySet(IEnumerable<int> set)
        {
            Console.WriteLine("- {" + string.Join(", ", set) + "}");
        }
    }
}
