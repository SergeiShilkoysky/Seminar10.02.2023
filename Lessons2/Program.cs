// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя),
// например, 4->16; -3->9; -7->49

Console.Clear();

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Способ1 Квадрат числа " + value + " равен: " + value * value);

// способ 2 
Console.WriteLine("Способ2  Квадрат числа " + value + " равен: " + Math.Pow(value, 2));