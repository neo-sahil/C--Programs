using System;
class B
{
    static B()
    {
        Console.WriteLine("Static const B");
    }

    public B(){
        Console.WriteLine("Const B");
    }
}

class C:B
{
    static C(){
        Console.WriteLine("Static const C");
    }
    public C(){
        Console.WriteLine("const C");
    }
}

class Sta{
    static void Main(){
        C obj = new C();
        Console.ReadLine();
    }
}
