using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello "+name);

        Calculator c1 = new Calculator();
        c1.Calcu();

        OddEven o1 = new OddEven();
        o1.odd();

        Reverse r1 = new Reverse();
        r1.rev();

        Largest L1 = new Largest();
        L1.large();
    }
}
