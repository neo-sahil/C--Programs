using System;

class Condition
{
    static void Main()
    {
        int i=0,j=5,k=9;

        int x = i>j?(i>k)?i:k:(j>k)?j:k;

        Console.Write(x);
    }
}