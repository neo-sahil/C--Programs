using System;
class Program2
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width:");
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=n-i+1;j++)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }
    }
}