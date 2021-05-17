using System;
class Program8
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int x,binary=0,i=1;;
        while(n>0)
        {
            x=n%2;
            binary += i*x;
            i*=10;
            n/=2;
        }
        Console.WriteLine("Binary is {0}",binary);
    }
}