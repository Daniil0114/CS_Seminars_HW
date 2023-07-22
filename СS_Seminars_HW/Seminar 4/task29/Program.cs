// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] MakeRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100); // Запрет вывода трехзначных чисел.
    return array;
}

int[] array = MakeRandomArray(new Random().Next(10)); // больше в терминал не влезет. 
// Для вывода массива на 3 либо 5 элементов, как в примере задачи, следует метод Next заполнить как Next(3,6)
Console.WriteLine("[" + string.Join(", ", array) + "]");
// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 11);
//     Console.Write(" " + num (i) + ",");
//  }
// Console.Write("]");

// int num (int a)
// {
//     return numbers[a];
// }