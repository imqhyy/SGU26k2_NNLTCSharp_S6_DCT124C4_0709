namespace Bai11;
using System;

public class Bai11
{
    public static string StrReverse (string arg)
    {
        int lenght = arg.Length;
        //tạo mảng kí tự để đảo ngược arg
        char[] temp = new char[lenght];
        //lấy kí tự cuối cùng của chuỗi gắn vào đầu mảng kí tự
        //sau đó index++ i-- là sẽ được chuỗi đảo ngược
        int index = 0;
        for(int i = lenght - 1; i >= 0; i--)
        {
            temp[index] = arg[i];
            index++;
        }
        string reverse = new string(temp);
        return reverse;
    }
}