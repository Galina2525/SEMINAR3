// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палиндроном (симметричным)
//142212->No
//23432->Yes
//12821->Yes
Console.WriteLine("Enter five-digit number");
string numberStr = Console.ReadLine();
if (numberStr.Length ==5)
{
    if(numberStr[0]==numberStr[4] & numberStr[1]==numberStr[3])
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("You enter wrong number!");
}