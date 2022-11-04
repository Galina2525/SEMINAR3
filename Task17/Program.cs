// 1-я четверть х > 0 && y >0
//2-я четверть x < 0 && y > 0
// 3-я четверть x < 0 && y < 0
// 4-я четверть x > 0 && y < 0
// Напишите программу, которя принимает на вход координаты точки( Х и Y), причем X не равно 0 и Y 
// не равно 0 и выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Enter point X coordinate");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter point Y coordinate");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Point is in the first coordinate quater");
}
else if(x < 0 && y > 0)
{
Console.WriteLine("Point is in the second coordinate quater");
}
else if(x < 0 && y < 0)
{
Console.WriteLine("Point is in the third coordinate quater");
}
else if(x > 0 && y < 0) // пишем if else, а не просто if (в 4 случаях), чтобы исключить ноль во всех
// четырех случаях, а не только в последнем
{
Console.WriteLine("Point is in the fourth coordinate quater");
}
else
{
    Console.WriteLine("It's imposible determine coordinate quater");
}

