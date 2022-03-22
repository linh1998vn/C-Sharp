using System;

namespace GeometryExample
{
    class Cylinder
    {
        static string Process(double a, double b)
        {
            double BaseArea, LateralArea, TotalArea, Volumn;
            BaseArea = a * a * Math.PI;
            LateralArea = 2 * Math.PI * a * b;
            TotalArea = 2 * Math.PI * a * (a + b);
            Volumn = Math.PI * a * a * b;
            return "Base: " + BaseArea + " | Laterial: " + LateralArea + " | Total: " + TotalArea + " | Volume: " + Volumn;
        }
        static void Main(string[] args)
        {
            double r, h;
            Console.Write("Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cylinder Characteristics\nRadius: " + r + ", Height: " + h);
            Console.WriteLine(Process(r, h));
        }
    }
}