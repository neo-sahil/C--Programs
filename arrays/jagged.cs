using System;

class jagged
{
    static void Main()
    {
        int[][] arr1 = new int[3][];
        int[][] arr2 = new int[3][];

        arr1[0] = new int[3]{5,7,6};
        arr1[1] = new int[4]{5,8,3,9};
        arr1[2] = new int[2]{10,7};

        arr2[0] = new int[3];
        arr2[1] = new int[4];
        arr2[2] = new int[2];

        //Console.WriteLine("yes");   

        Console.WriteLine("Array 1");
        for(int i=0;i<arr1.Length;i++)
        {
            for(int j=0;j<arr1[i].Length;j++)
            {
                Console.Write("{0} ",arr1[i][j]);
                if(i==0)
                {
                    arr2[i][j] = arr1[i][j] * arr1[i][j];
                }
                else if(i==1)
                {
                    int x = arr1[i][j];
                    int fect=1;
                    while(x>=1)
                    {
                        fect *= x;
                        x--;
                    }
                    arr2[i][j] = fect;
                }
                else if(i==2)
                {
                    arr2[i][j] = arr1[i][j] * arr1[i][j] * arr1[i][j];   
                }
            }
            Console.WriteLine();    
        }

        Console.ReadLine();
        Console.WriteLine("Array 2");
        for(int i=0;i<arr2.Length;i++)
        {
            for(int j=0;j<arr2[i].Length;j++)
            {
                Console.Write("{0} ",arr2[i][j]);
            }
            Console.WriteLine();    
        }
    }
}