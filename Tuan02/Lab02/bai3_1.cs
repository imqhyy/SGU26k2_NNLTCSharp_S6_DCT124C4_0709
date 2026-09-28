using System;

namespace bai3_1;

public class Program
{
    public static void Main(string[] args)
    {
        
        PhanSo[] arr = new PhanSo[]
        {
            new PhanSo(1, 2),
            new PhanSo(3, 7),
            new PhanSo(9, 8),
            new PhanSo(7, 5)
        };

        Console.WriteLine("Mang ban dau");
        foreach (PhanSo i in arr)
        {
            Console.Write(i.ToString() + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Mang sau sap xep");
        Array.Sort(arr);
        foreach (PhanSo i in arr)
        {
            Console.Write(i.ToString() + " ");
        }
    }
}

public class PhanSo : IComparable<PhanSo>
{
    private int tuso;
    private int mauso;

    public int TuSo {get => tuso; set => tuso = value;}
    public int MauSo
    {
        get => mauso;
        set
        {
            if(value != 1) mauso = value;
            else throw new Exception("Mau so phai khac 0!");
        }
    }
    public PhanSo()
    {
        tuso = 0;
        mauso = 1;
    }

    public PhanSo(PhanSo B)
    {
        this.tuso = B.tuso;
        this.mauso = B.mauso;
    }

    public PhanSo(int x, int y)
    {
        if(y == 0) throw new Exception("Mau so phai khac 0!");
        this.tuso = x;
        this.mauso = y;
    }

    //Override ToString()
    public override string ToString()
    {
        return $"{tuso}/{mauso}";
    }

    //Overload Operator
    //Toán tử 1 ngôi
    public static PhanSo operator + (PhanSo A)
    {
        return A;
    }

    public static PhanSo operator - (PhanSo A)
    {
        return new PhanSo(-A.tuso, A.mauso);
    }


    //Toán tử 2 ngôi
    public static PhanSo operator + (PhanSo A, PhanSo B)
    {
        int mausomoi = A.mauso * B.mauso;
        int tusoAquydong = A.tuso * B.mauso;
        int tusoBquydong = B.tuso * A.mauso;
        int tusomoi = tusoAquydong + tusoBquydong;
        
        int ucln = 1;
        int limit = Math.Min(Math.Abs(mausomoi), Math.Abs(tusomoi));
        //Tìm ước chung lớn nhất cho tử số và mẫu số
        for(int i = 1; i <= limit; i++)
        {
            if(tusomoi % i == 0 && mausomoi % i == 0) ucln = i;
        }

        if(ucln != 1)
        {
            tusomoi = tusomoi / ucln;
            mausomoi = mausomoi / ucln;
        }

        return new PhanSo(tusomoi, mausomoi);
    }

    public static PhanSo operator - (PhanSo A, PhanSo B)
    {
        int mausomoi = A.mauso * B.mauso;
        int tusoAquydong = A.tuso * B.mauso;
        int tusoBquydong = B.tuso * A.mauso;
        int tusomoi = tusoAquydong - tusoBquydong;
        
        int ucln = 1;
        int limit = Math.Min(Math.Abs(mausomoi), Math.Abs(tusomoi));
        //Tìm ước chung lớn nhất cho tử số và mẫu số
        for(int i = 1; i <= limit; i++)
        {
            if(tusomoi % i == 0 && mausomoi % i == 0) ucln = i;
        }

        if(ucln != 1)
        {
            tusomoi = tusomoi / ucln;
            mausomoi = mausomoi / ucln;
        }

        return new PhanSo(tusomoi, mausomoi);
    }

    public static PhanSo operator * (PhanSo A, PhanSo B)
    {
        int tusomoi = A.tuso * B.tuso;
        int mausomoi = A.mauso * B.mauso;
        
        int ucln = 1;
        int limit = Math.Min(Math.Abs(tusomoi), Math.Abs(mausomoi));
        //Tìm ước chung lớn nhất cho tử số và mẫu số
        for(int i = 1; i <= limit; i++)
        {
            if(tusomoi % i == 0 && mausomoi % i == 0) ucln = i;
        }

        if(ucln != 1)
        {
            tusomoi = tusomoi / ucln;
            mausomoi = mausomoi / ucln;
        }

        return new PhanSo(tusomoi, mausomoi);
    }

    public static PhanSo operator / (PhanSo A, PhanSo B)
    {
        int tusomoi = A.tuso * B.mauso;
        int mausomoi = A.mauso * B.tuso;
        
        int ucln = 1;
        int limit = Math.Min(Math.Abs(tusomoi), Math.Abs(mausomoi));
        //Tìm ước chung lớn nhất cho tử số và mẫu số
        for(int i = 1; i <= limit; i++)
        {
            if(tusomoi % i == 0 && mausomoi % i == 0) ucln = i;
        }

        if(ucln != 1)
        {
            tusomoi = tusomoi / ucln;
            mausomoi = mausomoi / ucln;
        }

        return new PhanSo(tusomoi, mausomoi);
    }


    //So sánh
    public static bool operator > (PhanSo A, PhanSo B)
    {
        return (A.tuso * B.mauso) > (B.tuso * A.mauso);
    }
    public static bool operator < (PhanSo A, PhanSo B)
    {
        return (A.tuso * B.mauso) < (B.tuso * A.mauso);
    }
    public static bool operator >= (PhanSo A, PhanSo B)
    {
        return (A.tuso * B.mauso) >= (B.tuso * A.mauso);
    }
    public static bool operator <= (PhanSo A, PhanSo B)
    {
        return (A.tuso * B.mauso) <= (B.tuso * A.mauso);
    }
    public static bool operator == (PhanSo A, PhanSo B)
    {
        return (A.tuso * B.mauso) == (B.tuso * A.mauso);
    }
    public static bool operator != (PhanSo A, PhanSo B)
    {
        return (A.tuso * B.mauso) != (B.tuso * A.mauso);
    }

    public int CompareTo(PhanSo other)
    {
        if(this == other) return 0;
        if(this > other) return 1;
        else return -1;
    }
}