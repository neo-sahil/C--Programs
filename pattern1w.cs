using System;

class Pattern1
{
    static void Main()
    {
        int i=1,j=1;

        do
        {
            do
            {
                Console.Write("* ");
                j++;
            }while(j<i);
            j=0;
            i++;
            Console.WriteLine();
        }while(i<=5);
    }
}