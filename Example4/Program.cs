// Найти расстояние между точками в пространстве 2D
Console.WriteLine ("Ведите координату x1");
int x1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Ведите координату y1");
int y1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Ведите координату x2");
int x2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Ведите координату y2");
int y2 = int.Parse(Console.ReadLine() ?? "0");

var xy = ((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1));
var distance = Math.Sqrt (xy);
Console.WriteLine ($"Расстояние между точками равно - {distance}"); 