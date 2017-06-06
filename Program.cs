using System;

namespace OTP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar usd20 = new Dollar(20);
            Console.WriteLine("usd20: " + usd20);
            Dollar usd50 = new Dollar(50);
            Console.WriteLine("usd50: " + usd50);

            Console.WriteLine("usd20 + usd50 = " + (usd20 + usd50));
            Console.WriteLine("usd20 * 2 = " + (usd20 * 2));

            Console.WriteLine("usd20 == usd50 : " + (usd20 == usd50));

            Console.WriteLine("usd20 == usd20 : " + (usd20 == new Dollar(20)));

            Console.WriteLine("usd50 hash code: " + usd50.GetHashCode());
            Console.WriteLine();
            Purse purse = new Purse();
            Listener listener = new Listener();
            purse.DataChanged += listener.Listen;

            Console.WriteLine("purse.PrintSumUAH():");
            purse.PrintSumUAH();
            purse.Add(usd20);
            Console.WriteLine("purse.Add(usd20)");
            purse.PrintSumUAH();
            Console.WriteLine();
            purse.Add(new Euro(20));
            purse.Add(new Euro(30));
            purse.Add(new Pound(10));
            Console.WriteLine("purse.Add(new Euro(20))\npurse.Add(new Euro(30))\npurse.Add(new Pound(10))");

            Console.WriteLine();
            Console.WriteLine("purse.PrintSumUAH():");
            purse.PrintSumUAH();

            Console.WriteLine();
            Console.WriteLine("purse.PrintSumCur():");
            purse.PrintSumCur();

            Console.WriteLine();
            Console.WriteLine("purse.Remove(eur30)");
            purse.Remove(new Euro(30));
            purse.PrintSumCur();

            Console.WriteLine();
            Console.WriteLine("purse.Clear()");
            purse.Clear();

            Console.WriteLine();
            Console.WriteLine("Listener log:");
            listener.PirntLog();

            Console.ReadKey();
        }
    }
}
