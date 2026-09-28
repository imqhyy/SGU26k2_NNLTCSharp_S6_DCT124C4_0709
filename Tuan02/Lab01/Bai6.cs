namespace Bai6;
using System;

public class Bai6
{
    public static int MaxInteger(int x, int y, int z)
    {
        int max = x;
        if(max < y) max = y;
        if(max < z) max = z;
        return max;
    }
}