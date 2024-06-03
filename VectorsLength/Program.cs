using System;
using System.Linq;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

class Program
{
    static void Main()
    {
        Console.Write("Въведете броя на векторите: ");
        int N = int.Parse(Console.ReadLine());

        var vectors = new Vector<double>[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Въведете координатите на вектор {i + 1}: ");
            double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            vectors[i] = Vector<double>.Build.DenseOfArray(coordinates);
        }

        double shortestLength = vectors.Min(v => v.L2Norm());

        Console.WriteLine($"Дължината на най-късият вектор е: {shortestLength}");
    }
}
