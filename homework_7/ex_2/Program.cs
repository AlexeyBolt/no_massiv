﻿/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

Console.WriteLine("Ведите размер массива через Enter: ");
double[,] array = new double[InputIntNumber(), InputIntNumber()];
FillArray(array);
PrintArray(array);
Console.WriteLine("Ведите индекс элемента через Enter: ");
int rowNumber = InputIntNumber();
int columnNumber = InputIntNumber();
FindIndexInArray(array, rowNumber, columnNumber);

void FindIndexInArray(double[,] matrixArray, int i, int j)
{
    if (i < 0 || i > matrixArray.GetLength(1) - 1 ||
        j < 0 || j > matrixArray.GetLength(1) - 1 )
    {
        Console.Write("такого числа в массиве нет");
    }
    else
        Console.Write(matrixArray[i, j]);
}

int InputIntNumber()
{
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void FillArray(double[,] matrixArray)
{
    Random rand = new Random();

    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = rand.Next(-10, 10);
        }
    }
}

void PrintArray(double[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write($"{matrixArray[i, j]} ");
        }
        Console.WriteLine();
    }
}