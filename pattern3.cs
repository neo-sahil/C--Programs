using System;

class Pattern3
{
    static void Main()
    {
        int k=1;
        for(int i=1;i<=5;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(k+" ");
                k+=2;
            }
            Console.WriteLine();
        }
    }
}