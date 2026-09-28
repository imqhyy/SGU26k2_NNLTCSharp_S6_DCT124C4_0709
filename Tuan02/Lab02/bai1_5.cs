using System;

namespace bai1_5;

public class Program
{
    public static void Main(String[] args)
    {
        DonThuc A = new DonThuc();
        A.a = 2;
        A.x = 3;
        A.n = 2;
        Console.WriteLine($"Q(x) = {A.a}.x^{A.n}, x = {A.x} => Q(x) = {A.TinhGiaTri()}");
        Console.WriteLine($"Q'(x) = {A.a}.{A.n}.x^{A.n - 1}, x = {A.x} => Q'(x) = {A.TinhDaoHam()}");
    }
}

public class DonThuc
{
    public double a, x;
    public int n;

    public double TinhGiaTri()
    {
        return (a * Math.Pow(x, n));
    }

    public double TinhDaoHam()
    {
        return (a * n * Math.Pow(x, n - 1));
    }
}