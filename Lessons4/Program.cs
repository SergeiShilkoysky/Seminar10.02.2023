//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
// ( 4-> "-4,-3,-2,-1,0,1,2,3,4"/ 2->"-2,-1,0,1,2")

Console.Write("Вариант 1-й:  ");
Console.WriteLine("введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = -number; i <= number; i++)
   {
    Console.Write(i + ", " );
   }

Console.WriteLine("Задача решена");
Console.WriteLine("Вариант 2-й:  ");
Console.WriteLine("введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());
int B = -N;
while( B <= N)
{
    Console.WriteLine($"{B} ");
    B++;
}