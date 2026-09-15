namespace Bai12;
using System;

public class Bai12
{
    public static void run()
    {
        string arg;
        Console.Write("Nhap chuoi: ");
        arg = Console.ReadLine();
        //Chuyển chuỗi sang kí tự thường
        string lower = arg.ToLower();
        //Chuyển chuỗi sang kí tự hoa
        string upper = arg.ToUpper();
        Console.WriteLine("Chuoi sang ki tu thuong: " + lower);
        Console.WriteLine("Chuoi sang ki tu hoa: " + upper);
        Console.WriteLine("Do dai chuoi: " + arg.Length);
    }
}