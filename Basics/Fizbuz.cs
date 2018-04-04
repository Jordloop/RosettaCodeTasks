using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type a number.");
        int num = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= num; i++)
        {
            if(i % 15 == 0) { Console.WriteLine("fizbuz"); }
            else if (i % 5 == 0) { Console.WriteLine("fiz"); }
            else if (i % 3 == 0) { Console.WriteLine("buz"); }
            else { Console.WriteLine(i); }
        }
    }
}
