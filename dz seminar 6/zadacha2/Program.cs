/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double PointIntersectionX(double a1, double a2, int b1, int b2) 
{
    double x = (b2 - b1) / (a1 - a2);
    return Math.Round(x, 2);
}

double PointIntersectionY(double a1, double a2, int b1, int b2, double x) 
{
    double y = a1 * x + b1;
    return Math.Round(y, 2);
}

Console.Write("b1 = ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("b2 = ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = int.Parse(Console.ReadLine());


double resultX = PointIntersectionX(k1, k2, b1, b2);
double resultY = PointIntersectionY(k1, k2, b1, b2, resultX);

if (k1 == k2) Console.WriteLine("Паралелльные прямые");
else 
{
    Console.WriteLine("Точка пересечений:");
    Console.WriteLine($"X = {resultX}");
    Console.WriteLine($"Y = {resultY}");
}
