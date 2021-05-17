using System;

class Armstrong
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int x= Convert.ToInt32(Console.ReadLine());
        int N=x;
        int n,sum=0;

        while(x>0)
        {
            n=x%10;
            sum+=(n*n*n);
            x/=10;
        }
        
        if(N==sum)
        {
            Console.WriteLine("{0} is a Armstorng number",N);
        }
        else
        {
            Console.WriteLine("{0} is not a Armstorng number",N);
        }
    }
}