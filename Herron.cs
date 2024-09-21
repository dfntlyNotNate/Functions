using System;

public class Triangle
{
    public static double TriangleArea(double a, double b, double c)
    {

        double s = (a + b + c) / 2;


        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return area;
    }

    public static void Main(string[] args)
    {

        double a = 3, b = 4, c = 5;
        double area = TriangleArea(a, b, c);
        Console.WriteLine($"The area of the triangle is {area}");
    }
}
