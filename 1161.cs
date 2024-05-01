using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split();

        int fat1 = Convert.ToInt32(val[0]);
        int fat2 = Convert.ToInt32(val[1]);

        int less1 = fat1;
        int less2 = fat2;

        if(fat1 != 0)
        {
           for (int i = 1; i != fat1; i++)
                less1 = less1 * (fat1 - i);
           fat1 = less1;
        }
        else
            fat1 = 1;

        if(fat2 != 0)
        {
           for (int i = 1; i != fat2; i++)
                less2 = less2 * (fat2- i);
        fat2 = less2;
        }
        else
            fat2 = 1;
      
        Console.WriteLine(fat1 + fat2);
    }
}