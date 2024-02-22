using System;
class triangle
{
static void Main()
    {
        Console.WriteLine("Enter the base of the triangle: ");
        double base = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * Length * base;
        Console.WriteLine($"The area of the triangle is: {area}");
    }
}
