//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго (a=25, b=5 ->да / a=2, b=10 ->нет / a=9, b=-3 ->да / a=-3, b=9 ->нет)

Console.Clear();
Console.WriteLine("Способ 1");
Console.Write("Введите A: ");
int number1=int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int number2=int.Parse(Console.ReadLine());

if(Math.Pow(number2,2)==number1)
{
    Console.WriteLine("A является квадратом B");
}
else
{
    Console.WriteLine("A не является квадратом B");   
}

Console.WriteLine("Способ 2");
Console.Write("Введите число a: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b =Convert.ToInt32(Console.ReadLine());

double c = Math.Pow(b, 2);

if(c == a)
{
    Console.WriteLine ("Первое число является квадратом второго");
}
else
{
    Console.WriteLine ("не является квадратом второго");
}
if(c == b)
{
    Console.WriteLine ("Первое число является квадратом второго");
}




