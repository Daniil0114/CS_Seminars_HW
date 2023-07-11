// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Pront(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Pront ("Введите трёхзначное число: ");

if(number >= 100 & number < 1000)
{
    int mid = (number % 100 - number % 10) /10;
    Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
{
    Console.WriteLine("Число не является трёхзначным");
}