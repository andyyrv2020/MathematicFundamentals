using System;
using System.Numerics;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

class Program
{
    static void Main()
    {
        Console.WriteLine("Въведете коефициентите на полинома, разделени със интервал:");
        string[] coefficientsStr = Console.ReadLine().Split(' ');

        double[] coefficients = Array.ConvertAll(coefficientsStr, double.Parse);

        var polynomial = new Polynomial(coefficients);

        var roots = FindRoots(polynomial);

        Console.WriteLine("Корените на полинома са:");
        foreach (var root in roots)
        {
            Console.WriteLine(root);
        }
    }

    static Complex[] FindRoots(Polynomial polynomial)
    {
        return polynomial.Roots();
    }
}
