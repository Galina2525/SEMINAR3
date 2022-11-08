// 1-я четверть х > 0 && y >0
// 2-я четверть x < 0 && y > 0
// 3-я четверть x < 0 && y < 0
// 4-я четверть x > 0 && y < 0
//Напишите программу, которая по заданному номеру четверти показывает диапазон возможных
//координат точек в этой четверти (X и Y)

Console.WriteLine("Enter number of quater (1,2,3,4)");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater == 1)
{
    Console.WriteLine("x > 0 && y >0");
}
else if(quater == 2)
{
     Console.WriteLine("x < 0 && y >0");
}
else if(quater == 3)
{
     Console.WriteLine("x > 0 && y <0");
}
else if(quater == 4)
{
     Console.WriteLine("x > 0 && y <0");
}
else
{
     Console.WriteLine("Your enter wrong quater!");
}