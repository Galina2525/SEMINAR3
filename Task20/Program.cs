// Напишите прграмму, которая принмает на вход координаты двух точек и находит
// расстояние между ними в пространстве
//A(3,6,8) B(2,1,-7) ->15,84
//A(7,-5,0) B(1,-1,9)->11,53

Console.WriteLine("Enter coordinate x of point A ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y of point A ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate z of point A ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate X of point B ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate point Y of point B ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate z of point B ");
int zB = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA, 2) + Math.Pow(zB-zA,2));

//res = Math.Round(res,2);
//Console.WtiteLine(res);

Console.WriteLine($"{res:F2}");