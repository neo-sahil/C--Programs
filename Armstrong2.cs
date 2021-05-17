using System;

class Armstrong2
{
    static void Main()
    {
        int x,sum,n,i=1;;
        while(i<=1000)
        {
            x=i;
            sum=0;
            while(x>0)
            {
                n=x%10;
                sum+=(n*n*n);
                x/=10;
            }
            
            if(i==sum)
            {
                Console.WriteLine("{0}",i);
            }
            i++;
        }
    }
}