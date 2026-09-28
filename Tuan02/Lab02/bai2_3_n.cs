using System;
using System.Collections;
using System.Text.Json.Serialization.Metadata;

namespace bai2_3_n;

public class Program
{
    public static void Main(string[] args)
    {
        DaThuc P = new DaThuc();
        P.Input();
        P.Output();
        double x = 3;
        Console.Write($"P({x}) = {P.TinhGiaTri(x)}");
    }
}

public class DaThuc
{
    private int n; //Bậc của đa thức
    private double[] a; //Hệ số a

    //Constructor
    public DaThuc()
    {
        n = 0;
        a = new double[1] { 0 };
    }

    public DaThuc(int n)
    {
        if (n < 0) n = 0;
        this.n = n;
        a = new double[n + 1];
    }

    public DaThuc(DaThuc t)
    {
        n = t.n;
        a = new double[n + 1];
        for (int i = 0; i <= n; i++)
        {
            a[i] = t.a[i];
        }
    }


    //Indexer
    public double this[int i]
    {
        get
        {
            if (i >= 0 && i <= n)
                return a[i];
            else
                throw new Exception("i khong hop le!");
        }

        set
        {
            if (i >= 0 && i <= n)
                a[i] = value;
            else
                throw new Exception("i khong hop le!");
        }
    }

    public void Input()
    {
        Console.Write("Nhap bac cua da thuc: ");
        n = int.Parse(Console.ReadLine());
        a = new double[n + 1];
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Nhap a[{i}] = ");
            a[i] = double.Parse(Console.ReadLine());
        }
    }

    public void Output()
    {
        Console.Write("P(x) = ");
        bool isFirst = true;

        for (int i = 0; i <= n; i++)
        {
            // Bỏ qua các đơn thức có hệ số bằng 0 (trừ trường hợp toàn bộ bằng 0)
            if (a[i] == 0 && n > 0)
                continue;

            if (!isFirst && a[i] > 0)
                Console.Write(" + ");
            else if (!isFirst && a[i] < 0)
                Console.Write(" - ");
            else if (a[i] < 0)
                Console.Write("-");

            double absValue = Math.Abs(a[i]);

            if (i == 0)
            {
                Console.Write(absValue);
            }
            else if (i == 1)
            {
                if (absValue == 1)
                    Console.Write("x");
                else
                    Console.Write($"{absValue}x");
            }
            else
            {
                if (absValue == 1)
                    Console.Write($"x^{i}");
                else
                    Console.Write($"{absValue}x^{i}");
            }

            isFirst = false;
        }

        if (isFirst) // Nếu tất cả hệ số đều bằng 0
            Console.Write("0");

        Console.WriteLine();
    }

    public double TinhGiaTri(double x)
    {
        // Sử dụng lược đồ Horner để tối ưu việc tính toán:
        // P(x) = a0 + x*(a1 + x*(a2 + ... + x*an))
        double ketQua = a[n];
        for (int i = n - 1; i >= 0; i--)
        {
            ketQua = ketQua * x + a[i];
        }
        return ketQua;
    }
}