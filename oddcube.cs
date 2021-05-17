using System;

class Fectorial2
{
    static void Main()
    {
       
        int sum=0;
        for(int j=1;j<=20;j++)
        {
            if(j%2!=0)
            {
                sum += j*j*j;
            }
        }
        Console.WriteLine("sum of cubes = {0}",sum);
    }
}