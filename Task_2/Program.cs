//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координаты точки х1: ");
int x2 = ReadInt("Введите координаты точки х2: ");
int y1 = ReadInt("Введите координаты точки y1: ");
int y2 = ReadInt("Введите координаты точки y2: ");
int z1 = ReadInt("Введите координаты точки z1: ");
int z2 = ReadInt("Введите координаты точки z2: ");

double a = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) *(z2 - z1);
Console.Write("Расстояние между точками в 3D пространстве составляет: " + Sqrt(a));


double Sqrt(double a)
{
    return Math.Sqrt(a);
}


int ReadInt (string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}