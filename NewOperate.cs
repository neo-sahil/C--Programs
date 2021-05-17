using System;

class Condition
{
    static void Main()
    {
        int? n1 = null;
        int? n2 = null;
        int? n3 = 1;
        int n4;

        n4 =(int)n1??n2??n3;
        Console.Write(n4);
    }
}