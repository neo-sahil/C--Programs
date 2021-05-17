using System;

class Pattern3
{
    static void Main()
    {
        
        for(int i=1;i<=3;i++)
        {
            for(int j=1;j<=4;j++)
            {
                if(i==1 || i==3)
                {
                    Console.Write("* ");
                }
                else if(j==1 || j==4)
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