using System;

class Condition
{
    static void Main()
    {
        int i=1;
        AA:
        Console.WriteLine(i+" ");
        i++;
        if(i<=10)
            goto AA;
    }
}