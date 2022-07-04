// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[5];
if (9999 < num && num < 100000)
{
    for (int i = 0; i < 5; i = i + 1)
    {
        array[i] = num % 10;
        num = num / 10;
        // Console.Write(array [i]);
    }
}
else System.Console.WriteLine("Число не пятизначное");
if (array[0] == array[4] && array[1] == array[3])
{
    System.Console.WriteLine("Число палендром");
}
else System.Console.WriteLine("Число не палендром");