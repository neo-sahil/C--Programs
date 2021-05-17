using System;

class Pattern2
{
    static void Main()
    {
        int k;
        for(int i=1;i<=5;i++)
        {
            k=1;
            for(int j=1;j<=i;j++)
            {
                Console.Write(k+" ");
                if(k==0)
                    k=1;
                else
                    k=0;
            }
            Console.WriteLine();
        }
    }
}