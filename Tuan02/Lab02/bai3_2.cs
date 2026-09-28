using System;

namespace bai3_2;

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

        MyArrayUtils.Sort(arr);

        foreach (NhanVien i in arr)
        {
            Console.WriteLine(i.ToString());
        }

    }
}

public class MyArrayUtils
{
    // Phương thức sắp xếp tổng quát Generic
    public static void Sort<T>(T[] arr) where T : IComparable<T>
    {
        if (arr == null || arr.Length <= 1) return;

        int n = arr.Length;
        // Áp dụng thuật toán sắp xếp nổi bọt (Bubble Sort)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Nếu arr[j] lớn hơn arr[j + 1] -> Hoán đổi vị trí
                if (arr[j].CompareTo(arr[j + 1]) > 0)
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
        if(this.TinhLuong() > other.TinhLuong()) return 1;
        if(this.TinhLuong() == other.TinhLuong()) return 0;
        return -1;
    }

    public override string ToString()
    {
        return $"{hoten}|{this.TinhLuong()}";
    }
}