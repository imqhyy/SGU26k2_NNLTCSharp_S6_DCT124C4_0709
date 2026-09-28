namespace Bai15;
using System;

public class mang
{
    private int[] arr;
    private int n;

    public void NhapMang()
    {
        Console.Write("Nhap n: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.Write("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap n: ");
        }
        arr = new int[n];
        bool thanhcong = false;
        while (!thanhcong)
        {
            try
            {
                Console.WriteLine("Nhap phan tu cua mang: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"arr[{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                thanhcong = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Vui long nhap so!");
                Console.Write("Nhan enter de tiep tuc...");
                Console.ReadLine();
            }
        }
    }

    public void XuatMang()
    {
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public int Min_Arr()
    {
        int min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (min > arr[i]) min = arr[i];
        }
        return min;
    }

    public int Max_Arr()
    {
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (max < arr[i]) max = arr[i];
        }
        return max;
    }

    public bool kt_snt(int num)
    {
        if (num < 2) return false;
        for(int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    public int[] SNT()
    {
        //tạo mảng động vì chưa biết mảng có bao nhiêu số nguyên tố
        List<int> temp = new List<int>();

        for(int i = 0; i < n; i++)
        {
            if (kt_snt(arr[i])) temp.Add(arr[i]);
        }

        //Chuyển mảng động về mảng bình thường rồi return
        int[] arr_snt = temp.ToArray();
        return arr_snt;
    }
}