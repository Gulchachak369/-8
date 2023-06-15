// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

void ReplaceRowColomns(int[,] matrix, int[,] resultmatrix)
{
    for (int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            resultmatrix[i, j] = matrix[j, i];
        }
    }
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[,] resultmatrix = new int[n, m];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
ReplaceRowColomns(matrix, resultmatrix);
PrintMatrix(resultmatrix);
