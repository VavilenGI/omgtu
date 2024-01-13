using System;
using System.Security.Cryptography;

class Program
{
    static double  F(double N)
    {
        if (N == 3) return 1;
        else if (N < 3) return 0;
        else 
        {
            double s1=(Math.Floor(N / 2));
            double s2=Math.Floor(N / 2) + (N % 2);
            return F(s1)+ F(s2);
        }
    }
    static void Main()
    {
        double N=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(F(N));
    }
}
