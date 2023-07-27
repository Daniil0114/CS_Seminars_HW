// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string FindInArray(int userNumber, int[,] matrix)
{
    if (userNumber < 10)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == userNumber)
                {
                    return $"{i}, {j}";
                }
            }
        }
    }
    else
    {
        int row = userNumber / 10;
        int col = userNumber % 10;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i == row & j == col)
                {
                    return $"{matrix[i, j]}";
                }
            }
        }
    }
    return "такого числа в массиве нет";
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateAndPrintTwoDimentionArray()
{
    int[,] matrix = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[,] matrix = CreateAndPrintTwoDimentionArray();
int findNumberOrPosition = GetInfo("Введите число: ");
string position = FindInArray(findNumberOrPosition, matrix);
Console.WriteLine($"{findNumberOrPosition} -> {position}");