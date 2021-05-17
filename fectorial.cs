using System;

class Fectorial
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int x = Convert.ToInt32(Console.ReadLine());
        int fect=1;

        for(int i=x;i>0;i--)
        {
            fect *= i;
        }
        Console.WriteLine("Fectorial of {0} is {1}",x,fect);
    }
}