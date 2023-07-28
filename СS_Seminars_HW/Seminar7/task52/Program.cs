// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] GetAverage(int[,]array);
double[] average = new double[array.GetLength(1)];
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            average[i] = average[i] + average[j,i]; 
        }
        average[i] = average[i] / array.GetLength(0);
    }
    return average;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int number = GetInfo("Введите размер массива: ");
int[,] array = CreateIntArray(number, number);
PrintIntArray(array);
double[] average = GetAverage(array);
Console.Write($"Среднее арифметическое каждого столбца: " + string.Join("; ", average));