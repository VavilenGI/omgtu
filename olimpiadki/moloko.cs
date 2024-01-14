using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program
{
    
    static void Main()
    {
        Console.WriteLine("Введите кол-во фирм");
        int n= int.Parse( Console.ReadLine() ),  fnum=0;
        double min_ = int.MaxValue, cena=0;
        for( int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите данные");
            int x1= int.Parse( Console.ReadLine() );
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());

            int v1 = x1 * y1 * z1;
            int v2 = x2 * y2 * z2;
            int s1 = 2 * x1 * y1 + 2 * y1 * z1 + 2 * z1 * x1;
            int s2 = 2 * x2 * y2 + 2 * y2 * z2 + 2 * z2 * x2;

            cena = (c2 * s1 - c1 * s2) / (v2 * s1 - v1 * s2);
            if (cena < min_)
            {
                min_ = cena;
                fnum = i + 1;
            }
        }
        min_ = Math.Round(min_*1000, 2);
        Console.WriteLine($"номер фирмы: {fnum}, цена:{min_}");
    }
}