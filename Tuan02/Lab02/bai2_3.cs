using System;
using System.Collections;

namespace bai2_3;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayInteger A = new ArrayInteger();
        A.Input();
        A.Output();
        Console.WriteLine();
        Console.Write("Cac so chan: ");
        A.SoChan();
    }
}

public class ArrayInteger
{
    private ArrayList ints;

    public ArrayInteger()
    {
        ints = new ArrayList();
    }

    public ArrayInteger(ArrayInteger A)
    {
        this.ints = A.ints;
    }

    public int this[int index]
    {
        get
        {
            //Kiểm tra xem index có hợp lệ không
            if(index < 0 || index >= ints.Count)
            {
                throw new Exception("Index khong hop le");
            } 

            return (int)ints[index];
        }

        set
        {
            //Kiểm tra xem index có hợp lệ không
            if(index < 0 || index >= ints.Count)
            {
                throw new Exception("Index khong hop le");
            } 

            ints[index] = value;
        }
    }

    public void Input()
    {
        int n;
        Console.Write("Nhap so phan tu muon them vao mang: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap cac phan tu:");
        for(int i = 0; i < n; i++)
        {
            Console.Write("Phan tu thu " + (i + 1) + ": ");
            ints.Add(int.Parse(Console.ReadLine()));
        }
    }

    public void Output()
    {
        for(int i = 0; i < ints.Count; i++)
        {
            Console.Write(ints[i] + " ");
        }
    }

    public void SoChan()
    {
        for(int i = 0; i < ints.Count; i++)
        {
            if((int)ints[i] % 2 == 0)
                Console.Write(ints[i] + " ");
        }
    }
}