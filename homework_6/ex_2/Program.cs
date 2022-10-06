double[,] array = new Double[2, 2];
FillArray(array);
PrintArray(array);
CrossPoint(array);


void PrintArray(double[,] matrixArray)
{
    int row = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrixArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrixArray)
{
    int rows = matrixArray.GetLength(0);
    int columns = matrixArray.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine($"Числа из ряда {i+1}.");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Столбец {j+1}: ");
            matrixArray[i, j] = int.Parse(Console.ReadLine() ?? "0");
        }
    }
}

void CrossPoint(double[,] matrixArray)
{
  
    double x = (matrixArray[0, 1] - matrixArray[0, 0]) / (matrixArray[1, 0] - matrixArray[1, 1]);
    double yOne = Math.Round(matrixArray[1, 0] * x + matrixArray[0, 0], 2);
    double yTwo = Math.Round(matrixArray[1, 1] * x + matrixArray[0, 1], 2);


    Console.WriteLine($"координаты  пересечения : ({yOne}; {yTwo})");

}