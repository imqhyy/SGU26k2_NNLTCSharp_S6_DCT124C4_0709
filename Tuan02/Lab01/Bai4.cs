namespace Bai4;
using System;


public class Bai4
{
    public static void run()
    {
        int x;
        Console.Write("Nhap so nguyen x: ");

        //Kiểm tra xem chuỗi vừa nhập có phải số nguyên không
        //Nếu đúng thì trả về 1, dấu ! sẽ chuyển thành 0, vòng lặp kết thúc
        //Nếu không phải trả về 0, dấu ! chuyển thành 1, vòng lặp tiếp tục chạy
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Vui long nhap so nguyen!");
            Console.Write("Nhap so nguyen x: ");
        }

        int y;
        Console.Write("Nhap so nguyen y: ");
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Vui long nhap so nguyen!");
            Console.Write("Nhap so nguyen y: ");
        }
        int z = 1;
        for (int i = 0; i < y; i++)
        {
            z *= x;
        }
        Console.WriteLine("Ket qua {0} mu {1} la: {2}", x, y, z);
    }
}