using System;

namespace bai3_4;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        PTBac2Console app = new PTBac2Console();


        //Lamda expression
        app.Choose += (choice) =>
        {
            // Code chạy mỗi khi người dùng chọn một mục
            Console.WriteLine($"[Log]: Nguoi dung vua nhap chuc nang so {choice}");
        };

        // Bắt đầu chạy menu
        app.Run();
    }
}


//Lớp ConsoleMenu
public class ConsoleMenu
{
    // Danh sách các tiêu đề chức năng
    protected List<string> menuItems = new List<string>();

    // Delegate và Event xử lý khi chọn chức năng
    public delegate void MenuChooseHandler(int choice);
    public event MenuChooseHandler Choose;

    // Thêm một mục menu vào danh sách
    public void AddMenuItem(string item)
    {
        menuItems.Add(item);
    }

    // Phương thức hiển thị menu ra màn hình
    public virtual void Display()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Menu");
        for (int i = 0; i < menuItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }
        Console.WriteLine("0. Thoat chuong trinh");
        Console.WriteLine("------------------------------");
    }

    // Phương thức ảo để các lớp kế thừa có thể override xử lý trực tiếp
    public virtual void Execute(int choice)
    {
        // Kích hoạt sự kiện Choose (nếu có hàm đăng ký qua app.Choose += ...)
        Choose?.Invoke(choice);
    }

    // Vòng lặp điều khiển chính
    public void Run()
    {
        int choice = -1;
        do
        {
            Display();
            Console.Write("Thuc hien: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 0)
                {
                    Console.WriteLine("Da thoat chuong trinh!");
                    break;
                }
                else if (choice > 0 && choice <= menuItems.Count)
                {
                    Execute(choice); // Gọi xử lý logic
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen!");
            }

            Console.WriteLine("\nNhan phim bat ki de tiep tuc...");
            Console.ReadKey();
            Console.Clear();
        } while (choice != 0);
    }
}

//Lớp giải phương trình bậc 2
public class PTBac2Console : ConsoleMenu
{
    private double a, b, c;
    private bool daNhapHeSo = false;

    public PTBac2Console()
    {
        // Thiết lập danh sách chức năng cụ thể cho PT bậc 2
        AddMenuItem("Nhap he so (a, b, c)");
        AddMenuItem("Giai phuong trinh bac 2");
    }

    // Cách 1: Mở rộng bằng KẾ THỪA (Override phương thức Execute)
    public override void Execute(int choice)
    {

        base.Execute(choice);
        switch (choice)
        {
            case 1:
                NhapHeSo();
                break;
            case 2:
                GiaiPT();
                break;
            default:
                // Gọi hàm cha để kích hoạt sự kiện nếu có
                
                break;
        }
    }

    private void NhapHeSo()
    {
        Console.Write("Nhap he so a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
            Console.Write("Nhap lai a: ");

        Console.Write("Nhap he so b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
            Console.Write("Nhap lai b: ");

        Console.Write("Nhap he so c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
            Console.Write("Nhap lai c: ");

        daNhapHeSo = true;
        Console.WriteLine($"=> Phuong trinh: {a}x^2 + {b}x + {c} = 0");
    }

    private void GiaiPT()
    {
        if (!daNhapHeSo)
        {
            Console.WriteLine("Ban chua nhap he so! Vui long chon chuc nang 1 truoc.");
            return;
        }

        Console.WriteLine($"Giai phuong trinh: {a}x^2 + {b}x + {c} = 0");

        if (a == 0)
        {
            // Trở thành bx + c = 0
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Phuong trinh vo so nghiem." : "Phuong trinh vo nghiem.");
            }
            else
            {
                Console.WriteLine($"Puong trinh bac 1 co nghiem x = {-c / b:F2}");
            }
            return;
        }

        // Tính delta
        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {x:F2}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phuong trinh co 2 nghiem phan biet:\n  x1 = {x1:F2}\n  x2 = {x2:F2}");
        }
    }
}