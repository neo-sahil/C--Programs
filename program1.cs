using System;

class Program1
{
    static void Main()
    {
        char[] ch = new char[3];
        for(int i=0;i<3;i++)
        {
            Console.Write("Enter Letter:");
            ch[i] = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
        }
        for(int i=2;i>=0;i--)
        {
            Console.Write(ch[i] + " ");
        }
    }
}