using System;

class Palindrom
{
    static void  Main()
    {
        Console.Write("Enter a number:");
        int x= Convert.ToInt32(Console.ReadLine());
        int N=x;
        int n,rev=0;

        while(x>0)
        {
            n=x%10;
            rev=rev*10+n;
            x/=10;
        }
        
        if(N==rev)
        {
            Console.WriteLine("{0} is a Palindrom number",N);
        }
        else
        {
            Console.WriteLine("{0} is a not Palindrom number",N);
        }
    }
}