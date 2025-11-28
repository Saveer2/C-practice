using System;

class OddEven
{
    public void odd()
    {
        Console.WriteLine("\n\n** \tODD EVEN **");

        Console.WriteLine("\nEnter A Number : ");
        int n =Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine(n+" Is Even Number!!");
        }
        else
        {
            Console.WriteLine(n+" Is Odd Number!!");
        }
    }
}