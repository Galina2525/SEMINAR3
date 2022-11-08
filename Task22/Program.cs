// Напишите программу, которая принимает на вход число(N) и выдает квадрат чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int i = 1;
while(i <= number)
{

Console.Write(i*i+ " ");
i++;
}
