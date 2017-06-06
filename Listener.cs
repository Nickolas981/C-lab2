using System;
using System.Collections.Generic;

namespace OTP_Lab2
{
    class Listener
    {
        List<string> log = new List<string>();

        public void Listen(string str)
        {
            log.Add(str);
        }
        public void PirntLog()
        {
            foreach (var item in log)
                Console.WriteLine(item);
        }
        public void PrintLast()
        {
            Console.WriteLine(log[log.Count]);
        }
    }
}
