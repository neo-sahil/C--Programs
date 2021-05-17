using System;

class Pattern1
{
    static void Main()
    {
        int i=1;
        int j=1;

        while(i<=5)
        {
            while(j<=i)
            {
                Console.Write("* ");
                j++;
            }
            j=1;
            i++;
            Console.WriteLine();
        }
    }
}