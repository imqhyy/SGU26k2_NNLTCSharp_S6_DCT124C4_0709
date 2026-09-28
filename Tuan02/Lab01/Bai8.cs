namespace Bai8;
using System;

public class Bai8
{
    public static void HoanVi(ref float x, ref float y)
    {
        float temp = x;
        x = y;
        y = temp;
    }
}