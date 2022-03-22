int n;
long result = 1;
Console.Write("Nhap so nguyen can tinh: ");

n = Convert.ToInt32(Console.ReadLine());

for (var i = 1; i <= n; i++)
{
    result *= i;
}

Console.WriteLine($"giai thua cua {n} la {result}");