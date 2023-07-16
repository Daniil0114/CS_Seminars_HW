// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палидромом

string Palindrome (string input_user_num)
{
    if (input_user_num [0] == input_user_num [4] & input_user_num [1] == input_user_num [3]) return "Да";
    else return "нет";
}

string GetInfo(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string user_num = GetInfo("Введите пятизначное число: ");
if (user_num.Length != 5) Console.WriteLine("Введено неверное число");
else Console.WriteLine($"{user_num} -> {Palindrome(user_num)}");
