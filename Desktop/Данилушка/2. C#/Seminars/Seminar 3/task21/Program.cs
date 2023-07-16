// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int A = x2 - x1;
    int B = y2 - y1;
    int C = z2 - z1;
    double lenght = Math.Sqrt(A * A + B * B + C * C);
    return lenght;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

Console.WriteLine(Distance3D(x1, y1, z1, x2, y2, z2));