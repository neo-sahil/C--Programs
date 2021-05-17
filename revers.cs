using System;

class Revers
{
    static void  Main()
    {
        Console.Write("Enter a number:");
        int x= Convert.ToInt32(Console.ReadLine());
        int n,rev=0;

        while(x>0)
        {
            n=x%10;
            rev=rev*10+n;
            x/=10;
        }
        Console.WriteLine(rev);
    }
}