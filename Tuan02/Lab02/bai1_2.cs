using System;


namespace bai1_2;

public class Program
{
    public static void Main(string[] args)
    {
        Point A = new Point();
        Point B = new Point();
        A.Input();
        B.Input();
        Console.Write("A: "); A.Output();
        Console.Write("B: "); B.Output();
        
        

        //Operator
        Point C = A + B;
        Console.WriteLine("A + B = " + C.ToString());
        C = A - B;
        Console.WriteLine("A - B = " + C.ToString());

        //Câu a
        Console.WriteLine("Khoang cach(method): " + A.Distance(B));
        Console.WriteLine("Khoang cach(static): " + Point.Distance(A, B));

        //Câu B
        Point I = A.TrungDiem(B);
        Console.WriteLine("Trung diem(method): I" + I.ToString());

        I = Point.TrungDiem(A, B);
        Console.WriteLine("Trung diem(static): I" + I.ToString());
    }

}

public class Point
{
    //Field
    private double x, y;

    //Property
    public double X{get => x; set => x = value;}
    public double Y{get => y; set => y = value;}

    //Constructor
    public Point()
    {
        x = 0;
        y = 0;
    }

    public void Input()
    {
        Console.Write("Nhap toa do X: ");
        Double.TryParse(Console.ReadLine(), out x);   
        Console.Write("Nhap toa do Y: ");
        Double.TryParse(Console.ReadLine(), out y);
    }

    public void Output()
    {
        Console.WriteLine("X = {0}, Y = {1}", x, y);
    }

    //Override toString()
    public override string ToString()
    {
        return $"({x}, {y})"; // Trả về dạng chuỗi (X, Y)
    }

    //Operator
    public static Point operator + (Point A, Point B)
    {
        Point temp = new Point();
        temp.x = A.x + B.x;
        temp.y = A.y + B.y;
        return temp;
    }

    public static Point operator - (Point A, Point B)
    {
        Point temp = new Point();
        temp.x = A.x - B.x;
        temp.y = A.y - B.y;
        return temp;
    }

    //Câu a
    //Cách 1: Phương thức thành viên
    public double Distance(Point B)
    {
        return Math.Sqrt(Math.Pow((this.x - B.x), 2) + Math.Pow((this.y - B.y), 2));
    }

    //Cách 2: Phương thức tĩnh
    public static double Distance(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));
    }

    //Câu b
    //Cách 1: phương thức thành viên
    public Point TrungDiem(Point B)
    {
        Point I = new Point();
        I.x = (this.x + B.x) / 2;
        I.y = (this.y + B.y) / 2;
        return I;
    }


    //Cách 2: phương thức tĩnh
    public static Point TrungDiem(Point A, Point B)
    {
        Point I = new Point();
        I.x = (A.x + B.x) / 2;
        I.y = (A.y + B.y) / 2;
        return I;
    }
}