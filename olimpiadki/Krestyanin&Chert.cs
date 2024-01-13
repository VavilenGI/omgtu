using System;
class Program
{
    static void Main()
    {
        double MaxN, a=0;
        MaxN = Convert.ToInt64(Console.ReadLine());
        for (double i = 1; i <= 1+Math.Log2(MaxN +1);i++)
        {
            a += Math.Floor(MaxN / (Math.Pow(2, i) - 1));
            Console.WriteLine(a);
        }
        Console.WriteLine(a);
    }
}