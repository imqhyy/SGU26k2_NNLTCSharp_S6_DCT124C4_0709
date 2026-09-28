using System;
using System.Collections.Generic;

namespace bai3_6;

public class Program
{
    static void Main(string[] args)
    {
        CuocThi cuocThi = new CuocThi();
        cuocThi.NhapDanhSach();
        cuocThi.XuatDanhSach();

        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}
public abstract class ThiSinh
{
    public string SBD { get; set; }
    public string HoTen { get; set; }
    public double Bai1 { get; set; }
    public double Bai2 { get; set; }
    public double Bai3 { get; set; }

    public ThiSinh() { }

    public virtual void Nhap()
    {
        Console.Write("Nhap so bao danh (SBD): ");
        SBD = Console.ReadLine();

        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap diem bai 1: ");
        Bai1 = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem bai 2: ");
        Bai2 = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem bai 3: ");
        Bai3 = double.Parse(Console.ReadLine());
    }

    // Phuong thuc truu tuong tinh tong diem
    public abstract double TinhTongDiem();

    public virtual void Xuat()
    {
        Console.Write($"SBD: {SBD,-8} | Ho ten: {HoTen,-20} | Tong diem: {TinhTongDiem():0.00}");
    }
}


public class ThiSinhChuyen : ThiSinh
{
    public double TiengAnh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem tieng Anh: ");
        TiengAnh = double.Parse(Console.ReadLine());
    }

    public override double TinhTongDiem()
    {
        double diemCong = 0;
        if (TiengAnh >= 9 && TiengAnh <= 10)
        {
            diemCong = 2;
        }
        else if (TiengAnh >= 7 && TiengAnh <= 8) // Theo de bai: 7 <= tiengAnh <= 8
        {
            diemCong = 1;
        }

        return Bai1 + Bai2 + Bai3 + diemCong;
    }

    public override void Xuat()
    {
        Console.Write("[Chuyen]   ");
        base.Xuat();
        Console.WriteLine($" (Diem Tieng Anh: {TiengAnh})");
    }
}


public class ThiSinhSieuCup : ThiSinh
{
    public double CSDL { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem CSDL: ");
        CSDL = double.Parse(Console.ReadLine());
    }

    public override double TinhTongDiem()
    {
        return Bai1 + Bai2 + Bai3 + CSDL;
    }

    public override void Xuat()
    {
        Console.Write("[Sieu Cup] ");
        base.Xuat();
        Console.WriteLine($" (Diem CSDL: {CSDL})");
    }
}


public class CuocThi
{
    private List<ThiSinh> danhSachTS = new List<ThiSinh>();

    public void NhapDanhSach()
    {
        Console.Write("Nhap so luong thi sinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thi sinh thu {i + 1} ---");
            Console.WriteLine("1. Thi sinh Chuyen");
            Console.WriteLine("2. Thi sinh Sieu cup");
            Console.Write("Chon doi tuong thi sinh (1 hoac 2): ");
            int loai = int.Parse(Console.ReadLine());

            ThiSinh ts;
            if (loai == 1)
            {
                ts = new ThiSinhChuyen();
            }
            else
            {
                ts = new ThiSinhSieuCup();
            }

            ts.Nhap();
            danhSachTS.Add(ts);
        }
    }

    public void XuatDanhSach()
    {
        Console.WriteLine("\n================ KET QUA CUOC THI ================");
        foreach (var ts in danhSachTS)
        {
            ts.Xuat();
        }
        Console.WriteLine("==================================================");
    }
}