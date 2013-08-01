/*Write a program that fills and prints a matrix of size (n, n) as shown below: 
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7 */
using System;

class FillsAndPrintsMatrixD
{
    static void Main()
    {
        Console.Write("Enter a number for the side of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        string direction = "down";//First direction will be down because the numbers are going down at first
        int row = 0;
        int col = 0;

        FillingTheMatrix(n, matrix, ref direction, ref row, ref col);
        PrintingTheMatrix(matrix);
    }

    private static void PrintingTheMatrix(int[,] matrix)//Printing the matrix
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 4}", matrix[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    private static void FillingTheMatrix(int n, int[,] matrix, ref string direction, ref int row, ref int col)
    {
        for (int i = 1; i <= n * n; i++)//Filling the matrix
        {
            if (direction == "down" && ((row > (n - 1)) || (matrix[row, col] != 0)))
            {
                direction = "right";
                row--;
                col++;
            }
            if (direction == "right" && ((col > (n - 1)) || (matrix[row, col] != 0)))
            {
                direction = "up";
                row--;
                col--;
            }
            if (direction == "up" && ((row < 0) || (matrix[row, col] != 0)))
            {
                direction = "left";
                row++;
                col--;
            }
            if (direction == "left" && ((col < 0) || (matrix[row, col] != 0)))
            {
                direction = "down";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "down")
            {
                row++;
            }
            if (direction == "right")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
            if (direction == "left")
            {
                col--;
            }
        }
    }
}
