using System;

class Pattern3
{
    static void Main()
    {
        dynamic[] arr = new dynamic[5];
        arr[0] = 1;
        arr[1] = '0';
        arr[2] = 2.34F;
        arr[3] = 2.34D;

        for(int i=0;i<4;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}