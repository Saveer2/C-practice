using System;

class Largest
{
    public void large()
    {
        char repeat;
        do
        {
            Console.WriteLine("\n\n** \tLargest Number **");

            Console.WriteLine("\nEnter Size Of Array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter your Array : ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
       
            int max = arr[0];

            for(int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Largest : "+max);

            Console.WriteLine("Do you want to repeat (y/n): ");
            repeat = Console.ReadLine().ToLower()[0];
        }while(repeat=='y');
    }
}