using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int [] k = { 1, 2, 3, 20 };
        int n=5, m=10, l=7;
        //formula
        for (int i=0; i<k.Length; i++)
        {
           int s = k[i]* (2 * l + 2 * n) + (k[i] * k[i] + k[i]) * m;
            Console.WriteLine($"k = {k[i]}: s = {s}");
        }
        //cikl
        for (int i =0; i < k.Length; i ++)
        {
            int s = 0;
            for (int j = 0; j < k[i]; j++)
            {
                s += 2 * l + 2 * n + 2 * m + 2 * m * j;
                
            }
            Console.WriteLine($"k = {k[i]}: s = {s}");
        }
    }
}