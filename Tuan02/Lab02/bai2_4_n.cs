using System;
using System.Collections;

namespace bai2_4_n;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayPhanSo arr = new ArrayPhanSo();
        arr.Input();
        Console.WriteLine("Tong = " + arr.TongPhanSo().ToString());
    }
}

public class PhanSo
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
}

public class ArrayPhanSo
{
    private PhanSo[] arr;
    private int n;
    public ArrayPhanSo()
    {
        n = 0;
        arr = new PhanSo[n];
    }

    public void Input()
    {
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        arr = new PhanSo[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = new PhanSo();
            Console.WriteLine("Nhap phan so thu " + (i + 1) + ": ");
            Console.Write("Tu so: ");
            arr[i].TuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so: ");
            arr[i].MauSo = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }

    public PhanSo TongPhanSo()
    {
        PhanSo tong = new PhanSo();
        
        for(int i = 0; i < n; i++)
        {
            tong = tong + arr[i];
            
        }
        return tong;
    }
}