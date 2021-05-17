using System;

class Pattern4
{
    static void Main()
    {
        int k;
        for(int i=1;i<=5;i++)
        {
            k=1;
            for(int j=1;j<=5;j++)
            {
                if(j>=5-i+1)
                {
                    Console.Write(k+" ");
                    k++;
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