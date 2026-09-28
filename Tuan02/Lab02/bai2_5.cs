using System;
using System.Collections;

namespace bai2_5;

public class Program
{
    public static void Main(string[] args)
    {
        NhanVien A = new NhanVien("Qh", 2000000, 1);
        NhanVien B = new NhanVien("Hq", 3000000, 0);
        NhanVien C = new NhanVien("Nh", 2000000, 1);
        PhongBan pb = new PhongBan();
        pb.Add(A);
        pb.Add(B);
        pb.Add(C);
        Console.Write("Tong luong phong ban = " + pb.TongLuongPhongBan());
    }
}

public class NhanVien
{
    private string hoten;
    private double mucluong;
    private int songayvang;

    public NhanVien()
    {
        hoten = "";
        mucluong = 0;
        songayvang = 0;
    }

    public NhanVien(string hoten, double mucluong, int songayvang)
    {
        this.hoten = hoten;
        this.mucluong = mucluong;
        this.songayvang = songayvang;
    }

    public double TinhLuong()
    {
        return mucluong - (songayvang * 100000);
    }
}

public class PhongBan
{
    ArrayList arrNhanVien;

    public PhongBan()
    {
        arrNhanVien = new ArrayList();
    }

    public NhanVien this[int index]
    {
        get
        {
            if (index < 0 || index >= arrNhanVien.Count)
                throw new Exception("index khong hop le!");
            return (NhanVien)arrNhanVien[index];
            
        }

        set
        {
            if (index < 0 || index >= arrNhanVien.Count)
                throw new Exception("index khong hop le!");
            arrNhanVien[index] = value;
        }
    }

    public void Add(NhanVien A)
    {
        arrNhanVien.Add(A);
    }
    public double TongLuongPhongBan()
    {
        double tong = 0;
        for(int i = 0; i < arrNhanVien.Count; i++)
        {
            tong += ((NhanVien)arrNhanVien[i]).TinhLuong();
        }
        return tong;
    }
}

