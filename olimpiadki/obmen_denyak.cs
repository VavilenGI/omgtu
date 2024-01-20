using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] a = Console.ReadLine().Split().Skip(1).Select(int.Parse).ToArray();
        int[] a_unhappy = Console.ReadLine().Split().Skip(1).Select(int.Parse).OrderByDescending(x => x).ToArray();
        int[] b = Console.ReadLine().Split().Skip(1).Select(int.Parse).ToArray();
        int[] b_unhappy = Console.ReadLine().Split().Skip(1).Select(int.Parse).OrderBy(x => x).ToArray();

        int[] money_a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int real_money = 0;

        for (int index = 0; index < money_a.Length; index++)
        {
            foreach (int unhappy in a_unhappy)
            {
                if (money_a[index] > unhappy)
                {
                    money_a[index] -= 1;
                }
            }
            foreach (int perev in a.Skip(index))
            {
                money_a[index] *= perev;
            }
            real_money += money_a[index];
        }

        int[] c = new int[b.Length];
        for (int i = b.Length-1 ; i >= 0; i--)
        {
            c[i] = real_money % b[i];
            real_money /= b[i];
        }
        Array.Reverse(c);
        Array.Resize(ref c, c.Length+1);
        c[c.Length-1]= real_money;

        for (int index = 0; index < c.Length; index++)
        {
            foreach (int unhappy in b_unhappy)
            {
                if (c[index] >= unhappy)
                {
                    c[index] += 1;
                }
            }
        }
        for (int i = c.Length-1; i >=0; i--)
        {
            Console.Write(c[i] + " ");
        }
    }
}