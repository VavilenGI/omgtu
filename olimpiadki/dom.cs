using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader sp = new StreamReader("input_s1_14.txt");
        string [] g = (sp.ReadLine().Split());
        int x = int.Parse(g[0]);
        int y = int.Parse(g[1]);
        int l = int.Parse(g[2]);
        int c1 = int.Parse(g[3]);
        int c2= int.Parse(g[4]);
        int c3= int.Parse(g[5]);
        int c4= int.Parse(g[6]);
        int c5 = int.Parse(g[7]);
        int c6 = int.Parse(g[8]);
        int p = 2*(x + y);
        int ost =0, min_sum=0;
        if (l > p) 
        {
            ost = l - p;
            p = 0;
        }
        else p -= l;
        if (c2 + c3 < c1)
        {
            min_sum += (l - ost) * (c2 + c3);
            l = 0;
        }
        else if (c2 + c6 + c4 + c5 < c1)
        {
            min_sum += (l - ost) * (c2 + c6 + c4 + c5);
            l = 0;
        }
        else
        {
            if (l < Math.Min(x, y))
            {
                min_sum += l * c1;
                l = 0;
            }
            else
            {
                min_sum += Math.Max(x, y) * c1;
                l -= Math.Max(x, y);
            }
        }
        if (c2 + c6 + c4 + c5 < c2 + c3)
        {
            if (l > 0) min_sum += (l - ost) * (c2 + c6 + c4 + c5);
            l = 0; 
        }
        if (l > 0) min_sum += (l - ost) * (c2 + c3);
        min_sum += p * (c4 + c5);
        min_sum += ost * (c2 + c6);
        Console.Write(min_sum);
    }
}