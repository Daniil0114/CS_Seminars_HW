// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Promt(string message) 
{ 
    Console.Write(message); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
int GetThirdRank(int num)
{
    while(num > 999)
    {
        num /=10;
    }
    return num % 10;
}

bool check(int num) //проверка на верность
{
    if (num < 100) return false;
    else
    {
        return true;
    }
}

int num = Promt("Введите число: ");
if(check(num) != true)
Console.WriteLine("Третьей цифры нет!");
else
{
    Console.WriteLine($"Третьей цифрой числа {num} является {GetThirdRank(num)}");
}