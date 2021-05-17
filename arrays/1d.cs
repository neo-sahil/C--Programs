using System;

class Person
{
    public string Name;
    public int aadhar;
    public short age;
    public long phone;
}

class D1 
{
    static void Main()
    {
        Console.Write("Enter the no of persons: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Person [] per = new Person[x];
        for(int i=0;i<x;i++)
        {
           per[i]=new Person();
        }

        for(int i=0;i<x;i++)
        {
            Console.WriteLine(); //just for gap
            Console.WriteLine("Enter the info of {0} person: ",(i+1));
            Console.Write("Name:");
            per[i].Name=Console.ReadLine();
            Console.Write("Aadhar no:");
            per[i].aadhar=Convert.ToInt32(Console.ReadLine());
            Console.Write("Age:");
            per[i].age=Convert.ToInt16(Console.ReadLine());
            Console.Write("Phone:");
            per[i].phone=Convert.ToInt64(Console.ReadLine());
        }

        Console.WriteLine(); // just for gap
        Console.Write("If you want to search by Name then press 1 or by aadhar then press 2: ");
        Console.WriteLine(); // just for gap
        int n = Convert.ToInt32(Console.ReadLine());

        if(n==1)
        {
            BB:
            Console.Write("Enter the Name:");
            Console.WriteLine(); // just for gap
            string name = Console.ReadLine();
            for(int i=0;i<x;i++)
            {
                if(per[i].Name == name)
                {
                    Console.WriteLine("Name: {0}",per[i].Name);
                    Console.WriteLine("Aadhar no: {0}",per[i].aadhar);
                    Console.WriteLine("Age: {0}",per[i].age);
                    Console.WriteLine("Phone no: {0}",per[i].phone);
                    break;
                }
                if(i==x-1)
                {
                    Console.Write("There is no person with the Name {0}",name);
                }
            }
            Console.WriteLine(); // just for gap
            Console.Write("if you want to search again press 0 otherwise any key!!");
            int x11 = Convert.ToInt32(Console.ReadLine());
            if(x11==0)
                goto BB;
        }
        else if(n==2)
        {
            CC:
            Console.Write("Enter the Aadhar no:");
            Console.WriteLine(); // just for gap
            int aad = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<x;i++)
            {
                if(per[i].aadhar == aad)
                {
                    Console.WriteLine("Name: {0}",per[i].Name);
                    Console.WriteLine("Aadhar no: {0}",per[i].aadhar);
                    Console.WriteLine("Age: {0}",per[i].age);
                    Console.WriteLine("Phone no: {0}",per[i].phone);
                    break;
                }
                if(i == x-1)
                {
                    Console.Write("There is no person with the Aadhar no. {0}",aad);
                }
                Console.WriteLine(); // just for gap
                Console.Write("if you want to search again press 0 otherwise any key!!");
                int x11 = Convert.ToInt32(Console.ReadLine());
                if(x11==0)
                    goto CC;
            }
        }
        else
        {
            Console.WriteLine("{0} is the wrong choice",n);
        }
    }
}