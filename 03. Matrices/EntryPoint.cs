using System;

//_1)_______________2)_______________3)________
// 1  5  9 13   |   1  8  9 16   |   7 11 14 16
// 2  6 10 14   |   2  7 10 15   |   4  8 12 15
// 3  7 11 15   |   3  6 11 14   |   2  5  9 13
// 4  8 12 16   |   4  5 12 13   |   1  3  6 10
 
class EntryPoint
{
    static void Main()
    {
        int N = 4;
        int[,] matrixOne = new int[N, N];
        int[,] matrixTwo = new int[N, N];
        int[,] matrixThree = new int[N, N];
        int number = 1;

        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            for (int j = 0; j < matrixOne.GetLength(1); j++)
            {
                matrixOne[j, i] = number;
                number++;
            }
        }

        PrintMatrix(matrixOne);
        Console.WriteLine();
        Console.WriteLine();

        number = 1;

        for (int i = 0; i < matrixTwo.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                {
                    matrixTwo[j, i] = number;
                    number++;
                }
            }
            else
            {
                for (int j = matrixTwo.GetLength(1) - 1; j >= 0; j--)
                {
                    matrixTwo[j, i] = number;
                    number++;
                }
            }            
        }

        PrintMatrix(matrixTwo);

        Console.WriteLine();
        Console.WriteLine();

        number = 1;

        int currentRow = 0;
        int currentCol = 0;
        int startingRow = N - 1;
        int startingCol = 0;
        int counter = 0;

        while (number <= N * N)
        {
            currentRow = startingRow + counter;
            currentCol = startingCol + counter;
            matrixThree[currentRow, currentCol] = number;
            number++;
            counter++;

            if (startingRow > 0 && currentRow == N - 1)
            {
                startingRow--;
                counter = 0;
            }
            else if (currentCol == N - 1)
            {
                startingCol++;
                counter = 0;
            }
        }

        PrintMatrix(matrixThree);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3}");
            }

            Console.WriteLine();
        }
    }
}
