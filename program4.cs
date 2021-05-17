using System;

class Program4
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Operation:");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number:");
        int y = Convert.ToInt32(Console.ReadLine());

        switch(op)
        {
            case '+':
                Console.WriteLine(x+" + "+y+" = "+(x+y));
                break;
            case '-':
                Console.WriteLine(x+" - "+y+" = "+(x-y));
                break;
            case '*':
                Console.WriteLine(x+" * "+y+" = "+(x*y));
                break;
            case '/':
                Console.WriteLine(x+" / "+y+" = "+(x/y));
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}