using System;

public class MyClass
{
    public static void nhapTT(out int a, out int b, out int c)
    {
        Console.WriteLine("Nhap Phuong Trinh Ax2 + Bx + C = 0");
        Console.Write("Nhap a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap c: ");
        c = Convert.ToInt32(Console.ReadLine());
    }


    public static int giaiPT(int a, int b, int c, ref float x1, ref float x2)
    {
        int result;
        float delta;
        if (a == 0)
        {
            result = 1;
            x1 = -c / b * 1.0f;
        }
        else
        {
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                result = 0;
            }
            else if (delta == 0)
            {
                result = 1;
                x1 = -b / (2 * a);
            }
            else
            {
                result = 2;
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
            }
        }
        return result;
    }
    public static void Main(string[] args)
    {
        int a, b, c;
        float x1 = 0, x2 = 0;

        nhapTT(out a, out b, out c);
        int result = giaiPT(a, b, c, ref x1, ref x2);

        if (result == 0)
            Console.WriteLine("Phuong trinh vo nghiem");
        else if (result == 1)
            Console.WriteLine($"Phuong trinh co nghiem duy nhat: {x1}");
        else
            Console.WriteLine($"Phuong trinh co 2 nghiem phan biet x1: {x1}, x2: {x2}");
    }
}