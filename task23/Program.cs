﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int jump = 1;

while (jump <= num)
{
    Console.Write($"{Math.Pow(jump, 3)} ");
    jump++;
}
