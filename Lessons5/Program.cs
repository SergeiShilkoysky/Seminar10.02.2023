//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
// 456->6  / 782->2 / 918 ->8

Console.Clear();
Console.Write("Вариант 1-й:  ");
Console.Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());
int y=num%10;

Console.WriteLine($"{y}");


Console.Write("Вариант 2-й:  ");
Console.WriteLine("введите трехзначное число "); // n
int n = Convert.ToInt32(Console.ReadLine());
int d = n%10;

Console.WriteLine(" " + d + " " );