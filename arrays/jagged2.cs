using System;

class Jagged2
{
    static void Main()
    {
        int[][,] arr1 = new int[2][,];
        
        arr1[0] = new int[2,2]{{5,7},{6,2}};
        //arr1[1] = new int[3,3]{{5,8,3},{9,6,3},{7,10,12}};
        arr1[1] = new int[2,3]{{5,8,3},{9,6,3}};

        int sum=0;
        int min=arr1[0][0,0];
        int max=arr1[0][0,0];
        int count = 0;

        for(int i=0;i<arr1.Length;i++)
        {
            for(int j=0;j<arr1[i].GetLength(0);j++)
            {
                for(int k=0;k<arr1[i].GetLength(1);k++)
                {
                    Console.Write("{0} ",arr1[i][j,k]);
                    count++;
                    sum += arr1[i][j,k];
                    if(arr1[i][j,k]<min)
                        min = arr1[i][j,k];
                    
                    if(arr1[i][j,k]>max)
                        max = arr1[i][j,k];
                }
                Console.WriteLine();
            }
            Console.WriteLine();    
        }

        Console.WriteLine("Sum of arrays elemets is : {0}",sum);
        Console.WriteLine("Mininum is : {0}",min);
        Console.WriteLine("Maximum is : {0}",max);
        Console.WriteLine("Total number of elemets is : {0}",count);
    }
}