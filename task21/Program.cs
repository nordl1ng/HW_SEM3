// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты точки A");
System.Console.Write("X = ");
int XA = int.Parse(Console.ReadLine()!);
System.Console.Write("Y = ");
int YA = int.Parse(Console.ReadLine()!);
System.Console.Write("Z = ");
int ZA = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты точки B");
System.Console.Write("X = ");
int XB = int.Parse(Console.ReadLine()!);
System.Console.Write("Y = ");
int YB = int.Parse(Console.ReadLine()!);
System.Console.Write("Z = ");
int ZB = int.Parse(Console.ReadLine()!);
int katet1 = XB - XA;
int katet2 = YB - YA;
int katet3 = ZB - ZA;
int distance2 = katet1 * katet1 + katet2 * katet2 + katet3 * katet3;
double distance = Math.Sqrt(distance2);
distance = Math.Round(distance,2);
System.Console.WriteLine(distance);