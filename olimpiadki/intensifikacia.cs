using System;
class Program
{
    static void Main()
    {
        char d = '.';
        Console.WriteLine("Введите начальную дату:");
        string[] data1 = Console.ReadLine().Split(d);
        DateTime data_1 = new DateTime(int.Parse(data1[2]), int.Parse(data1[1]), int.Parse(data1[0]));
        Console.WriteLine("Введите конечную дату:");
        string[] data2 = Console.ReadLine().Split(d);
        Console.WriteLine("Введите кол-во выпускаемой продукции в 1 день");
        int p1 = int.Parse(Console.ReadLine());
        int prod = p1;
        DateTime data_2 = new DateTime(int.Parse(data2[2]), int.Parse(data2[1]), int.Parse(data2[0]));
        TimeSpan raz = data_2.Subtract(data_1);
        int days = raz.Days;
        for (int i = 1; i < days+1; i++)
        {
            prod+= p1 + i;
        }
        Console.WriteLine(prod);
    }
}