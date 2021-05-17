using System;

class D2
{
    static void Main()
    {
        dynamic [,] shop = new dynamic[3,3];
        //laptop
        shop[0,0] = "Laptop";
        shop[0,1] = 30000;
        shop[0,2] = 10;

        //mobile
        shop[1,0] = "Mobile";
        shop[1,1] = 10000;
        shop[1,2] = 10;

        //Desktop
        shop[2,0] = "Desktop";
        shop[2,1] = 70000;
        shop[2,2] = 10;

        AA:

        Console.WriteLine();
        for(int i=0;i<3;i++)
        {
            if(shop[i,2] == 0)
            {
                continue;
            }
            else
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write("{0}  ",shop[i,j]);
                }
                Console.WriteLine();
            }
        }
        if(shop[0,2]==0 && shop[1,2]==0 && shop[2,2]==0 )
        {
            Console.WriteLine("Sorry we don not have anything!!!!");
            System.Environment.Exit(0);
        }

        Console.Write("What u want to purchase: ");
        string pname = Console.ReadLine();
        int price;
        for(int i=0;i<3;i++)
        {
            if(shop[i,0] == pname)
            {
                Console.Write("How much You want to purchase: ");
                int pq = Convert.ToInt32(Console.ReadLine());
                if(pq <= shop[i,2])
                {
                    price = shop[i,1];
                    Console.Write("Ok you are purchasing {0} {1} so your bill is {2} * {3} = {4}",pq,pname,price,pq,(price*pq));
                    shop[i,2] -= pq;
                    Console.ReadLine();
                    Console.WriteLine("Thanks for purchasing this product.....");
                    break;
                }
                else
                {
                    Console.WriteLine("We do not have that much quantity!!!");
                    break;
                }
            }
            if(i==2)
            {
                Console.WriteLine("We do not have this product!!!");
                break;
            }
        }
        AB:
        Console.Write("You want to continue shoping type Yes or No: ");
        string str = Console.ReadLine();
        if(str == "Yes" || str =="yes" || str=="YES")
        {
            goto AA;
        }
        else if(str == "No" || str=="no" || str=="NO")
        {
            Console.WriteLine("Good bye....");
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("We do not get that!!");
            goto AB;
        }
    }  
}