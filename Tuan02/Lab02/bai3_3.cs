using System;

namespace bai3_3;

public class Program
{
    public static void Main(string[] args)
    {
        NhanVien[] arr = new NhanVien[4]
        {
            new NhanVien("dqh", 2000000, 1),
            new NhanVien("ngt", 7000000, 3),
            new NhanVien("qbc", 4000000, 0),
            new NhanVien("xyz", 2000000, 2)
        };

        ThuatToanSapXep.SapXep(arr, NhanVien.SoSanh2NV);

        foreach (NhanVien i in arr)
        {
            Console.WriteLine(i.ToString());
        }
    }
}

public delegate int SoSanh<T>(T x, T y);

public class ThuatToanSapXep
{
    public static void SapXep<T>(T[] arr, SoSanh<T> compare)
    {
        if (arr == null || arr.Length <= 1 || compare == null) return;

        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Nếu compare trả về > 0 nghĩa là arr[j] đứng sau arr[j + 1] -> Đổi chỗ
                if (compare(arr[j], arr[j + 1]) > 0)
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

public class NhanVien : IComparable<NhanVien>
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

    public int CompareTo(NhanVien other)
    {
        if (this.TinhLuong() > other.TinhLuong()) return 1;
        if (this.TinhLuong() == other.TinhLuong()) return 0;
        return -1;
    }

    public static int SoSanh2NV(NhanVien a, NhanVien b)
    {
        return a.CompareTo(b);
    }

    public override string ToString()
    {
        return $"{hoten}|{this.TinhLuong()}";
    }
}