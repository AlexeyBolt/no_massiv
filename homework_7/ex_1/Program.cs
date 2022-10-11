// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] matrixArray)
{
    int rows = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);
    Random randoum = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrixArray[i, j] = Math.Round(Convert.ToDouble(randoum.Next(-10, 10)) + randoum.NextDouble(), 2);
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{Math.Round(matr[m, n], 2)}; ");
        }
        Console.WriteLine();
    }
}


double[,] matrix = new double[3, 4];


FillArray(matrix);
PrintArray(matrix);
