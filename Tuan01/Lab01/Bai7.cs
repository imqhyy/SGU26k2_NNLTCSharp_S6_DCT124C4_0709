namespace Bai7;
using System;

public class Bai7
{
    public static bool SNT(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0) return false;
        }
        return true;
    }
}