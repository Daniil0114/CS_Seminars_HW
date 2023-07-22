// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int daynum = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday (daynum));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int num)
{
    if(num > 0 & num < 8)
    {
        if(num == 7 || num == 6)
        {
            Console.Write($"Под цифрой {num} -> Выходной");
        }
        else
        {
            Console.Write($"Под цифрой {num} -> Будний");
        }
    }   
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому невозможно определить");

    }
    return " день.";
}