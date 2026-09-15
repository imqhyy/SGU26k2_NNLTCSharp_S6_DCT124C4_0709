namespace Bai5;
using System;

public class Bai5
{
    public static void run()
    {
        int chucnang;
        double x = 0, y = 0;
        double ketqua;
        bool daNhap = false; //Kiem tra xem x, y da nhap chua truoc khi tinh toan
        do
        {
            Console.WriteLine();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Nhap hai gia tri cho so thuc x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            while(!int.TryParse(Console.ReadLine(), out chucnang) || chucnang > 4) {
                Console.WriteLine("Chuc nang khong hop le!");
                Console.Write("Chon chuc nang: ");
            }
            switch(chucnang)
            {
                case 1:
                    Console.Write("Nhap x: ");
                    while(!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Vui long nhap so thuc!");
                        Console.Write("Nhap x: ");
                    }

                    Console.Write("Nhap y: ");
                    while(!double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("Vui long nhap so thuc!");
                        Console.Write("Nhap y: ");
                    }
                    daNhap = true;
                break;


                case 2:
                    //Kiem tra xem x, y da co gia tri chua
                    if (!daNhap) {
                        Console.WriteLine("Vui long thuc hien chuc nang 1 truoc!");
                        Console.Write("Nhap enter de tiep tuc...");
                        Console.ReadLine();
                        continue;
                    }
                    ketqua = Math.Pow(x, y);
                    Console.WriteLine("x^y = {0}", ketqua);
                break;

                case 3:
                    //Kiem tra xem x, y da co gia tri chua
                    if (!daNhap) {
                        Console.WriteLine("Vui long thuc hien chuc nang 1 truoc!");
                        Console.Write("Nhap enter de tiep tuc...");
                        Console.ReadLine();
                        continue;
                    }
                    //can bac 2 cua x
                    ketqua=Math.Sqrt(x);
                    Console.WriteLine("Can bac 2 cua x = {0}", ketqua);
                    //can bac 2 cua y
                    ketqua=Math.Sqrt(y);
                    Console.WriteLine("Can bac 2 cua y = {0}", ketqua);
                break;

                case 4:
                break;
            }
        } while (chucnang != 4);
    }    
}