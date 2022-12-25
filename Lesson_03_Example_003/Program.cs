// double GetDistanceOfXY(double x1, double x2, double y1, double y2)
// {
//     double x = (x1 - x2) * (x1 - x2);
//     double y = (y1 - y2) * (y1 - y2);
//     return Math.Sqrt(x + y);
// }


// double x1 = double.Parse(Console.ReadLine()!);
// double x2 = double.Parse(Console.ReadLine()!);
// double y1 = double.Parse(Console.ReadLine()!);
// double y2 = double.Parse(Console.ReadLine()!);

// double distanceOfXY = GetDistanceOfXY(x1, x2, y1, y2);
// Console.WriteLine($"Расстояние между точками А({x1}, {x2}) Б({y1}, {y2}): {distanceOfXY}");

var dot = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

Console.WriteLine(dot[0] + " " + dot[1]);