using System;

namespace bai1_1;

public class SinhVien
{
    private string _hovaten;
    private int _namsinh;

    //Constructor
    public SinhVien()
    {
        _hovaten = "";
        _namsinh = 0;
    }

    //Parameters Constructor
    public SinhVien(string hoVaTen, int namSinh)
    {
        HoVaTen = hoVaTen;
        NamSinh = namSinh;
    }

    //Copy Constructor
    public SinhVien(SinhVien sv)
    {
        this._hovaten = sv._hovaten;
        this._namsinh = sv._namsinh;
    }

    //Property
    public string HoVaTen
    {
        get
        {
            return _hovaten;
        }

        set
        {
            _hovaten = value;
        }
    }

    //Property
    public int NamSinh
    {
        get
        {
            return _namsinh;
        }

        set
        {
            if (value > 0)
            {
                _namsinh = value;
            }
        }
    }

    public int Tuoi => (_namsinh > 0 && _namsinh <= DateTime.Now.Year) ? DateTime.Now.Year - _namsinh : -1;


    //Method
    public void XuatThongTin()
    {
        Console.WriteLine($"Ho va ten: {HoVaTen} | Nam sinh: {NamSinh} | Tuoi: {Tuoi}");
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //Khởi tạo sinh viên
        SinhVien sv1 = new SinhVien();

        //Nhập tên sinh viên
        string temp;
        Console.Write("Nhap ho va ten: ");
        temp = Console.ReadLine();
        sv1.HoVaTen = temp;
        Console.Write("Nhap nam sinh: ");

        //Nhập tuổi sinh viên
        int namsinh;
        int.TryParse(Console.ReadLine(), out namsinh);
        sv1.NamSinh = namsinh;
        Console.WriteLine("Tuoi: " + sv1.Tuoi);

        //Xuất thông tin sinh viên
        sv1.XuatThongTin();
    }
}