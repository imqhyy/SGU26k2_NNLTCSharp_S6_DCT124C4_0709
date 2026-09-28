using System;
using System.Collections;

namespace bai2_4;

public class Program
{
    public static void Main(string[] args)
    {
        Array2D arr = new Array2D();
        arr.Input();
        arr.Output();
        Console.Write("So nguyen to: "); arr.timSNT();
    }
}

public class Array2D
{
    private int[,] arr;
    private int rows;
    private int cols;

    //Câu a
    public Array2D()
    {
        rows = 0;
        cols = 0;
        arr = new int[rows, cols];
    }
    public Array2D(int rows, int cols)
    {
        if(rows < 0 || cols < 0)
            throw new Exception("So hang va so cot phai lon hon 0");

        this.rows = rows;
        this.cols = cols;
        arr = new int[rows, cols];
    }
    
    //Câu b
    public int this[int rows, int cols]
    {
        get
        {
            if(rows < 0 || cols < 0 || rows >= this.rows || cols >= this.cols)
                throw new Exception("So hang hoac so cot khong hop le");
            
            return arr[rows, cols];
        }

        set
        {
            if(rows < 0 || cols < 0 || rows >= this.rows || cols >= this.cols)
                throw new Exception("So hang hoac so cot khong hop le");
            arr[rows, cols] = value;
        }
    }

    public void Input()
    {
        Console.Write("Nhap so dong: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: ");
        cols = int.Parse(Console.ReadLine());

        arr = new int[rows, cols];
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($"arr[{i}, {j}] = ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void Output()
    {
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public bool snt(int n)
    {
        if(n < 2) return false;
        for(int i = 2; i <= (int)Math.Sqrt(n); i++)
        {
            if(n % i == 0) return false;
        }  

        return true;      
    }

    public void timSNT()
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(snt(arr[i, j]))
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}