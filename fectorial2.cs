using System;

class Fectorial2
{
    static void Main()
    {
       
        long fect;
        for(int j=1;j<=20;j++)
        {
            fect=1;
            if(j%2==0)
            {
                for(int i=j;i>0;i--)
                {
                    fect *= i;
                }
                Console.WriteLine("Fectorial of {0} is {1}",j,fect);
            }
        }
    }
}