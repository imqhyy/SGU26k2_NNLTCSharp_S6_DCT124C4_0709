namespace Bai16;

using System;

public class Bai16
{

    public static void swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

    //nếu Tên của a trước b thì trả về true, không thì false
    public static bool SoSanhThuTuTen(string a, string b)
    {
        int index_name_a = a.LastIndexOf(" ") + 1;
        int index_name_b = b.LastIndexOf(" ") + 1;
        char kytu_a = a[index_name_a];
        char kytu_b = b[index_name_b];

        //so sánh tên
        while (true)
        {
            if (kytu_a < kytu_b)
            {
                return true;
            }
            else if (kytu_a > kytu_b)
            {
                return false;
            }
            else
            {
                // bé hơn Lenght - 1 thì khi index++ mới không vượt qua khỏi số ký tụ trong chuỗi
                if (index_name_a < a.Length - 1 && index_name_b < b.Length - 1)
                {
                    kytu_a = a[index_name_a++];
                    kytu_b = b[index_name_b++];
                }
                else if (index_name_a == a.Length - 1 && index_name_b < b.Length - 1)
                {
                    //trường hợp xảy ra khi người 1 có tên ngắn hơn người 2
                    return true;
                }
                else if (index_name_b == b.Length - 1 && index_name_a < a.Length - 1)
                {
                    //trường hợp xảy ra khi người 2 có tên ngắn hơn người 1
                    return false;
                }
                else if (index_name_a == a.Length - 1 && index_name_b == b.Length - 1)
                {
                    //trường xảy ra khi 2 người có tên giống nhau, phải so sánh họ đệm và họ
                    break;
                }

            }
        }

        //so sánh còn lại
        //biến này dùng để lưu lại vị trí so sánh
        int index_a = a.LastIndexOf(" ") - 1;
        int index_a_end = index_a;
        int index_b = b.LastIndexOf(" ") - 1;
        int index_b_end = index_b;
        while (true)
        {
            
            //tìm vị trí bắt đầu của tên đệm
            for (int i = index_a; i >= 0; i--)
            {

                if (a[i] == ' ')
                {
                    index_name_a = i + 1;
                    index_a = index_name_a;
                    break;
                }

                if (i == 0)
                {
                    index_a = 0;
                    index_name_a = 0;
                }
            }

            for (int i = index_b; i >= 0; i--)
            {

                if (b[i] == ' ')
                {
                    index_name_b = i + 1;
                    index_b = index_name_b;
                    break;
                }

                if (i == 0)
                {
                    index_b = 0;
                    index_name_b = 0;
                }
            }

            kytu_a = a[index_name_a];
            kytu_b = b[index_name_b];

            //tiến hành so sánh lần nữa
            while (true)
            {
                if (kytu_a < kytu_b)
                {
                    return true;
                }
                else if (kytu_a > kytu_b)
                {
                    return false;
                }
                else
                {
                    // bé hơn Lenght - 1 thì khi index++ mới không vượt qua khỏi số ký tụ trong chuỗi
                    if (index_name_a < index_a_end && index_name_b < index_b_end)
                    {
                        kytu_a = a[index_name_a++];
                        kytu_b = b[index_name_b++];
                    }
                    else if (index_name_a == index_a_end && index_name_b < index_b_end)
                    {
                        //trường hợp xảy ra khi người 1 có tên ngắn hơn người 2
                        return true;
                    }
                    else if (index_name_b == index_b_end && index_name_a < index_a_end)
                    {
                        //trường hợp xảy ra khi người 2 có tên ngắn hơn người 1
                        return false;
                    }
                    else if (index_name_a == index_a_end && index_name_b == index_b_end)
                    {
                        //trường xảy ra khi 2 người có tên giống nhau, phải so sánh họ đệm và họ
                        break;
                    }

                }
            }

            //Nếu chạy tới đây tức là vẫn chưa so sánh được
            //Ta sẽ kiểm tra xem coi có tên nào hết trước không
            

            if(index_a == 0 && index_b > 0)
            {   
                //tên b còn nhưng tên a chứng tỏ tên a ngắn hơn
                return true;
            } else if (index_a > 0 && index_b == 0)
            {
                //tên a còn nhưng tên b hết chứng tỏ tên b ngắn hơn
                return false;
            } else if (index_a == 0 && index_b == 0)
            {
                //tên a và tên b hết cùng lúc
                return true;
            }

            //nếu không thì trước khi vòng lặp lần nữa, ta sẽ chỉ định lại index_end
            index_a_end = index_a - 2;
            index_b_end = index_b - 2;
            index_a = index_a - 2;
            index_b = index_b - 2;

        }



    }
    public static void run()
    {
        string[] human;
        int n;
        Console.Write("Nhap so luong nguoi: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Vui long nhap so!");
            Console.Write("Nhan enter de nhap lai...");
            Console.ReadLine();
            Console.Write("Nhap so luong nguoi: ");
        }

        human = new string[n];

        for (int i = 0; i < n; i++)
        {
            
            while (true)
            {   
                Console.Write("Nhap ho ten nguoi thu {0}: ", i + 1);
                human[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(human[i]))
                {
                    Console.WriteLine("Vui long khong de trong!");
                    Console.Write("Nhan enter de tiep tuc...");
                    Console.ReadLine();
                } else break;
                
            }
            //xử lí các khoảng trắng thừa trong chuỗi
            human[i] = string.Join(" ", human[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        }

        //sắp xếp theo thứ tự chữ cái trong tên
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (!SoSanhThuTuTen(human[i], human[j]))
                {
                    swap(ref human[i], ref human[j]);
                }
            }
        }

        Console.WriteLine();
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(human[i]);
        }
    }
}