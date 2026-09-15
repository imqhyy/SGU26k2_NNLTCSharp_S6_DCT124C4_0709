namespace Bai14;
using System;

public class NhanVien
{
    private string hovaten;
    private float mucluong;
    private int songayvang;
    public NhanVien()
    {
        hovaten = "null";
        mucluong = 0;
        songayvang = 0;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho va ten: ");
        hovaten = Console.ReadLine();
        Console.Write("Nhap muc luong: ");
        while(!float.TryParse(Console.ReadLine(), out mucluong))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.Write("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap muc luong: ");
        }
        Console.Write("Nhap so ngay vang: ");
        while(!int.TryParse(Console.ReadLine(), out songayvang))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.Write("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap so ngay vang: ");
        }
    }

    public void XuatThongTin()
    {
        Console.WriteLine("Ho va ten: " + hovaten);
        Console.WriteLine("Muc luong: " + mucluong);
        Console.WriteLine("So ngay vang: " + songayvang);
        //Tính lương thực lãnh
        float luongthuclanh = mucluong - (float)(songayvang * 100000);
        if (luongthuclanh < 0) luongthuclanh = 0;
        Console.WriteLine("Luong thuc lanh: " + luongthuclanh + " VND");
    }

}