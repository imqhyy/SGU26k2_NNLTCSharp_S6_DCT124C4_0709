namespace Bai17;
using System;

public class mang2chieu
{
    int n, m;
    int[,] matrix;
    public void TaoMangNgauNhien()
    {
        Console.Write("Nhap so dong: ");
        while(!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.WriteLine("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap so dong: ");
        }
        Console.Write("Nhap so cot: ");
        while(!int.TryParse(Console.ReadLine(), out m))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.WriteLine("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap so dong: ");
        }


        //khởi tạo mảng
        matrix = new int[n, m];
        Random rand = new Random();
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                //rand.Next sinh số bao gồm cận dưới và loại trừ cận trên
                //rand.Next(10, 101) => 10 <= x < 101
                matrix[i, j] = rand.Next(10, 100 + 1); //10 <= x <= 100
            }
        }

        
    }

    public void XuatMang()
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public int[] MangChan()
    {
        List<int> temp = new List<int>();
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(matrix[i, j] % 2 == 0)
                {
                    temp.Add(matrix[i, j]);
                }
            }
        }

        return temp.ToArray();
    }

    public int[] MangLe()
    {
        List<int> temp = new List<int>();
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(matrix[i, j] % 2 != 0)
                {
                    temp.Add(matrix[i, j]);
                }
            }
        }

        return temp.ToArray();
    }
}