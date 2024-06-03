using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;

namespace MatrixCalculus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] firstData = {
                { 2, 1, 4 },
                { 3, 6, 5 },
                { 8, 9, 7 }
            };

            double[,] secondData = {
                { 2, 1, 4 },
                { 3, 6, 5 },
                { 8, 9, 7 }
            };

            string firstInputLine = Console.ReadLine();
            string[] firstInputValues = firstInputLine.Split(' ');
            int firstIndex = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int s = 0; s < 3; s++)
                {
                    firstData[i, s] = double.Parse(firstInputValues[firstIndex]);
                    firstIndex++;
                }
            }

            string secondInputLine = Console.ReadLine();
            string[] secondInputValues = secondInputLine.Split(' ');
            int secondIndex = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int s = 0; s < 3; s++)
                {
                    secondData[i, s] = double.Parse(secondInputValues[secondIndex]);
                    secondIndex++;
                }
            }

            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(firstData);
            Matrix<double> matrix2 = Matrix<double>.Build.DenseOfArray(secondData);

            Matrix<double> multiplyResult = matrix * 2;
            Console.WriteLine(multiplyResult);

            Matrix<double> addResult = matrix + matrix2;
            Console.WriteLine(addResult);

            Console.WriteLine($"Determinant: ");
            double determinant = matrix.Determinant();
            Console.WriteLine(determinant);

            var vector = new DenseVector(new[] { 12.0, 8.0, 5.0 });
            var solveVector = matrix.Solve(vector);
            Console.WriteLine(solveVector);
        }
    }
}
