/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Clear();

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintAMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2},");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine("]");
    }
}

int[,] array = CreateMatrixRndInt(6, 4, 1, 9);
PrintAMatrix(array);

int GetSum(int[,] arrays, int i)
{
    {
        int sum = arrays[i, 0];
        for (int j = 1; j < arrays.GetLength(1); j++)
        {
            sum += arrays[i, j];
        }
        return sum;
    }
}
int minSumRow = 0;
int sumRow = GetSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = GetSum(array, i);
    if (sumRow > tempSumLine)
    {
        sumRow = tempSumLine;
        minSumRow = i;
    }
}
Console.WriteLine($"Строкa с наименьшей суммой элементов: {minSumRow + 1} => {sumRow}");

//Console.WriteLine($"Cумма элементов каждой строки: ");
//PrintAMatrix(array);

