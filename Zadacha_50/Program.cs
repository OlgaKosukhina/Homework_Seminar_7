/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetNumberFromMatrix(int[,] matrix, int rowPosition, int columnsPosition)
{
    int row = rowPosition - 1;
    int col = columnsPosition - 1;

    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
    {
        int numberFromMatrix = matrix[row, col];
        Console.WriteLine(numberFromMatrix);
    }
    else
    {
        Console.WriteLine("There is no such number in matrix");
    }
}

Console.WriteLine("Insert number of rows: ");
int rowsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert number of columns: ");
int columnsNumber = int.Parse(Console.ReadLine());
int[,] array = GetArray(rowsNumber, columnsNumber);
PrintArray(array);

Console.WriteLine("Insert row position:");
int rowPosition = int.Parse(Console.ReadLine());
Console.WriteLine("Insert column position:");
int columnPosition = int.Parse(Console.ReadLine());
GetNumberFromMatrix(array, rowPosition, columnPosition);
