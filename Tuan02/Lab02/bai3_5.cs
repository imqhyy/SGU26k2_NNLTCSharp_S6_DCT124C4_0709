using System;

namespace bai3_5;

public class Program
{
    public static void Main(string[] args)
    {
        List<NhanVien> danhSachNV = new List<NhanVien>();

        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thong tin nhan vien thu {i + 1} ---");
            Console.WriteLine("1. Nhan vien kinh doanh");
            Console.WriteLine("2. Nhan vien san xuat");
            Console.Write("Chon loai nhan vien (1 hoac 2): ");
            int loai = int.Parse(Console.ReadLine());

            NhanVien nv;
            if (loai == 1)
            {
                nv = new NhanVienKinhDoanh();
            }
            else
            {
                nv = new NhanVienSanXuat();
            }

            nv.Nhap();
            danhSachNV.Add(nv);
        }

        // In danh sách lương (minh họa tính Đa hình: gọi TinhLuong() tương ứng từng loại)
        Console.WriteLine("\n================ Bang luong nhan vien ================");
        double tongLuong = 0;
        foreach (NhanVien nv in danhSachNV)
        {
            nv.Xuat();
            tongLuong += nv.TinhLuong();
        }

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"Tong tien luong: {tongLuong:N0} VND");

        Console.ReadKey();
    }
}

abstract public class NhanVien
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }

    public NhanVien() { }

    public NhanVien(string maNV, string hoTen)
    {
        MaNV = maNV;
        HoTen = hoTen;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ma nhan vien: ");
        MaNV = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
    }

    abstract public double TinhLuong();

    // Xuất thông tin
    public virtual void Xuat()
    {
        Console.WriteLine($"Ma NV: {MaNV,-10} | Ho ten: {HoTen,-20} | Luong: {TinhLuong():N0} VND");
    }
}

public class NhanVienKinhDoanh : NhanVien
{
    public double LuongCoBan { get; set; }
    public int SoHopDong { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap luong co ban: ");
        LuongCoBan = double.Parse(Console.ReadLine());
        Console.Write("Nhap so hop dong ky duoc: ");
        SoHopDong = int.Parse(Console.ReadLine());
    }

    // Công thức: Lương cơ bản + Số hợp đồng * 500.000
    public override double TinhLuong()
    {
        return LuongCoBan + (SoHopDong * 500000.0);
    }

    public override void Xuat()
    {
        Console.Write("[Kinh doanh] ");
        base.Xuat();
    }
}

public class NhanVienSanXuat : NhanVien
{
    public int SoSanPham { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong san pham lam duoc: ");
        SoSanPham = int.Parse(Console.ReadLine());
    }

    // Công thức: Số SP * 1000, nếu > 3000 SP thì thưởng thêm 5%
    public override double TinhLuong()
    {
        double luongGoc = SoSanPham * 1000.0;
        if (SoSanPham > 3000)
        {
            return luongGoc * 1.05; // Thưởng 5%
        }
        return luongGoc;
    }

    public override void Xuat()
    {
        Console.Write("[San xuat]  ");
        base.Xuat();
    }
}

