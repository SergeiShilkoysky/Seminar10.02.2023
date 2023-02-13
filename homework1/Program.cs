// Задача 2:  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7   /   a = 2 b = 10 -> max = 10   /  a = -9 b = -3 -> max = -3


//            1 вариант
Console.Write ("Введите 1-е число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите 2-е число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(numberA, numberB);
int min = Math.Min(numberA, numberB);
Console.Write ("Из 2-х чисел: max= " + max + " min= " + min);
Console.WriteLine();
if(numberA == numberB)
{
  Console.Write ("Введенные числа равны");  
}


/*             2 вариант
Console.Write ("Введите 1-е число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите 2-е число: ");
int numberB = int.Parse(Console.ReadLine());
int max = 0; int min = 0;

if(numberA > numberB)
{ max = numberA;
  min = numberB;}
else 
{ max = numberB;
  min = numberA;}
Console.Write ("Минимальное число: " + min + "  максимальное число: " + max);  
*/
