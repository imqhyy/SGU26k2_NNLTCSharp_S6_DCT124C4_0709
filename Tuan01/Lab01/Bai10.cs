namespace Bai10;
using System;

public class Bai10
{
    public static bool KtDoiXung (string arg)
    {
        int length = arg.Length;
        int index = 0;  //index này trỏ về kí tụ đầu chuỗi
        for(int i = length - 1; i >= length/2; i--)
        {
            //i=lenght-1 sẽ trỏ về cuối chuỗi
            if (arg[index] != arg[i]) return false;
            index++;
        }
        return true;
    }
}