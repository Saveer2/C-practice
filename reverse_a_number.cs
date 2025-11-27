using System;
using System.Text.RegularExpressions;

class Reverse
{
    public void rev()
    {
        char repeat;

        do
        {
            Console.WriteLine("\n\n** \tREVERSE A NUMBER **");

            Console.WriteLine("\nEnter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int r = 0;

            while (num > 0)
            {
                int digit = num % 10;
                r = r * 10 + digit;
                num /= 10;
            }

            Console.WriteLine("** Reversed : "+r);

            Console.WriteLine("Do you want to repeat (y/n): ");
            repeat = Console.ReadLine().ToLower()[0];

        }while(repeat == 'y');
    }
}