namespace Bai13;
using System;

public class SinhVien
{
    private string mssv;
    private string hovaten;
    private string diachi;
    private int nam;
    public SinhVien()
    {
        mssv = "null";
        hovaten = "null";
        diachi = "null";
        nam = 1;
    }
    public SinhVien(string mssv, string hovaten, string diachi, int nam)
    {
        this.mssv = mssv;
        this.hovaten = hovaten;
        this.diachi = diachi;
        this.nam = nam;
    }
    
    public void XuatThongTin()
    {
        Console.WriteLine("Ma so sinh vien: " + mssv);
        Console.WriteLine("Ho va ten: " + hovaten);
        Console.WriteLine("Dia chi: " + diachi);
        Console.WriteLine("Nam: " + nam);
    }
    public void NhapThongTin()
    {
        Console.Write("Nhap ma so sinh vien: ");
        mssv = Console.ReadLine();
        Console.Write("Nhap ho va ten: ");
        hovaten = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        diachi = Console.ReadLine();
        Console.Write("Nhap nam: ");
        while(!int.TryParse(Console.ReadLine(), out nam))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.Write("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap nam: ");
        }
    }
}