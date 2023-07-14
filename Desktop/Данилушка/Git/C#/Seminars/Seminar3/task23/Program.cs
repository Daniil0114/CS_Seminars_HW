﻿// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void DefCube(int num)
{
    Console.Write($"{num} -> ");
    for(int i = 1; i < num; i++)
    {
        Console.Write(i * i * i + ", ");
    }
    Console.WriteLine(num * num * num + ".");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите число: ");
DefCube(num);