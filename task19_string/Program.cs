// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
string s = (Console.ReadLine());
int l = s.Length;
if (l == 5)
{
    if (s[0] == s[4] && s[1] == s[3])
    {
        System.Console.WriteLine("Число палендром");
    }
    else System.Console.WriteLine("Число не палендром");
}
else System.Console.WriteLine("Число не пятизначное");
