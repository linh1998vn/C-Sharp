int n, max = 0;

do
{
    Console.WriteLine("Nhap so n: ");
    n = Convert.ToInt32(Console.ReadLine());

    if (max < n)
        max = n;
} while (n != 0);

Console.WriteLine($"So lon nhat la: {max}");