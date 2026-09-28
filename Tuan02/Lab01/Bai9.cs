namespace Bai9;
using System;

public class Bai9
{
    public static void MaxMin (float a, float b, float c, out float Max, out float Min)
    {
        Max = a;
        if(Max < b) Max = b;
        if(Max < c) Max = c;

        Min = a;
        if(Min > b) Min = b;
        if(Min > c) Min = c;
    }
}