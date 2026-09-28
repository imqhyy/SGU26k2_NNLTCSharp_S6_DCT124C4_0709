namespace Bai3;
using System;
public class Bai3
{
    public static void run()
    {
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen y: ");
        int y = int.Parse(Console.ReadLine());
        int z = 1;
        for (int i = 0; i < y; i++)
        {
            z *= x;
        }
        Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, z);
    }
}