//Напишите программу, 
//которая будет выдавать название дня недели по заданному номеру (3->Среда / 5 -> Пятница)

Console.Clear();
Console.Write("Вариант решения 1-й: ");
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());
 //int chislo = Convert.ToInt32(Console.ReadLine());

if(numberDayOfWeek==1)
{
    Console.WriteLine("Понедельник");
}
else if(numberDayOfWeek==2)
{
    Console.WriteLine("Вторник");
}
else if(numberDayOfWeek==3)
{
    Console.WriteLine("Среда");
}
else if(numberDayOfWeek==4)
{
    Console.WriteLine("Четверг");
}
else if(numberDayOfWeek==5)
{
    Console.WriteLine("Пятница");
}
else if(numberDayOfWeek==6)
{
    Console.WriteLine("Суббота");
}
else if(numberDayOfWeek==7)
{
    Console.WriteLine("Воскресенье");
}
else{
    Console.WriteLine("Введен неправильный номер");
}



Console.Write("Вариант решения 2-й: ");
Console.Write("Введите номер дня недели: ");
int chislo = int.Parse(Console.ReadLine());
//int chislo = Convert.ToInt32(Console.ReadLine());
switch(chislo)
    {
    case 1:
        Console.WriteLine("Понедельник");
        break;

    case 2:
        Console.WriteLine("Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

     case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        break;

    default: 
        Console.WriteLine("Такого не существует");
        break;
    }