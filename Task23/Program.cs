// Напишите программу, которая на вход принимает число (N) и выдает таблицу кубов чисел
// от 1 до N
// 3 -> 1,4,9
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= number)
{
    Console.Write(i*i*i + "  ");
    i++;
}

