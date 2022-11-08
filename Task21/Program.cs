// Напишите программу, которая на вход принимает координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// A(3,6 ) B(2,1) ->5,09
//A(7,-5)  B(1,-1) ->7,21

Console.WriteLine("Enter coordinate x of point A ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y of point A ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate X of point B ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate point Y of point A ");
int yB = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA, 2));

//res = Math.Round(res,2);
//Console.WtiteLine(res);

Console.WriteLine($"{res:F2}");


