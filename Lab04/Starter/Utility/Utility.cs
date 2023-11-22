﻿class Utils
{
    public static int Greater(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a; 
        a = b;
        b = temp;
    }

    public static bool Factorial (int n, out int answer)
    {
        int k;
        int f;
        bool ok = true;

        if (n < 0) 
        {
            ok = false;
        }

        try
        {
            checked
            {
                f = 1;
                for (
                    k = 2;
                    k <= n;
                    k++
                    )
                {
                    f = f * k;
                }
            }
        }

        catch
        {
            f = 0;
            ok = false;
        }
        answer = f;

        return ok;
        }
    }
