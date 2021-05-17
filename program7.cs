using System;
class Program7
{
    static void Main()
    {
        float distance;
        float hour,minut,second;
        float totaltimeSec,mps,kph,mph;

        Console.Write("Enter Distance(meters)");
        distance = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter time hours");
        hour = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter time minuts");
        minut = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter time seconds");
        second = Convert.ToSingle(Console.ReadLine());

        totaltimeSec = hour*60*60 + minut*60 + second;
        
        mps = distance/totaltimeSec;
        kph = mps * 3.6f;
        mph = kph / 1.609f;

        Console.WriteLine("Speed in mps = {0}",mps);
        Console.WriteLine("Speed in kph = {0}",kph);
        Console.WriteLine("Speed in mph = {0}",mph);
    }
}