using System;
class Program3
{
    static void Main()
    {
        string userid = "sahil";
        string pass = "123456";
        int x=0;

        while(true)
        {
            Console.Write("UserID:");
            string u = Console.ReadLine();
            if(u != userid)
            {
                x++;
                if(x>2)
                    break;
                Console.WriteLine("Invalid id");
                continue;
            }
            Console.Write("Password:");
            string p = Console.ReadLine();
            if(p!=pass)
            {
                x++;
                if(x>2)
                    break;
                Console.WriteLine("Invalid Password");
                continue;
            }
            if(u==userid && p==pass)
            {
                Console.WriteLine("welcome!");
                break;
            }
        }
    }
}