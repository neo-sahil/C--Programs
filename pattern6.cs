using System;

class Pattern3
{
    static void Main()
    {
        int n=3;
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=n*2-1;j++)
            {
                if(j>=n-i+1 && j<=n+i-1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}