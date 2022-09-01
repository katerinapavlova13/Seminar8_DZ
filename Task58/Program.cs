/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();

int[,] CreateMatrixRndInt1(int row, int col, int min, int max)
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;
}

void PrintAMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

int[,] CreateMatrixRndInt2(int row2, int col2, int min, int max)
{
    int[,] matrix2 = new int[row2, col2];
    Random rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}


int[,] ResMatrix(int[,] array1, int[,] array2)
{
    var resMatrix = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resMatrix[i, j] = 0;

            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resMatrix[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resMatrix;
}


int[,] array1 = CreateMatrixRndInt1(2, 2, -9, 9);
PrintAMatrix(array1);
Console.WriteLine();

int[,] array2 = CreateMatrixRndInt2(2, 2, -9, 9);
PrintAMatrix(array2);
Console.WriteLine();

int[,] array3 = ResMatrix(array1, array2);
Console.WriteLine("Произведение двух матриц: ");
PrintAMatrix(array3);





