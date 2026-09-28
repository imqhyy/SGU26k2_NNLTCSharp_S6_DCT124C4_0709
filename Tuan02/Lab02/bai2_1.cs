using System;
using System.Collections;

namespace bai2_1;

public class Program
{
    public static void Main(String[] args)
    {
        Point A = new Point();
        A.X = 1; A.Y = 2;
        Point B = new Point();
        B.X = 1; B.Y = 3;

        ArrayPoint ds = new ArrayPoint();
        ds.Add(A); ds.Add(B);
        for(int i = 0; i < ds.count; i++)
        {
            Console.WriteLine(ds[i].ToString());
        }
    }
}

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x = 0, double y = 0)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class ArrayPoint
{
    private ArrayList points;

    public ArrayPoint()
    {
        points = new ArrayList();
    }

    public Point this[int index]
    {
        get
        {
            //Kiểm tra xem index có hợp lệ không
            if(index < 0 || index >= points.Count)
            {
                throw new Exception("Index khong hop le");
            } 

            return (Point)points[index];
        }

        set
        {
            //Kiểm tra xem index có hợp lệ không
            if(index < 0 || index >= points.Count)
            {
                throw new Exception("Index khong hop le");
            } 

            points[index] = value;
        }
    }

    public void Add(Point P)
    {
        points.Add(P);
    }

    public int count => points.Count;
}