using System;
class Program6
{
    static void Main()
    {
        int x,y;

        Console.WriteLine("x = y2 - 2y +1");   
        Console.WriteLine();

        for(y=-5;y<=5;y++)
        {
            x = y*y - 2*y +1;
            Console.WriteLine("y = {0};  x=y2 - 2y +1 = {1}",y,x);
        }
    }
}