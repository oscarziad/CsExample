using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_1
{
    class BandSaw : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("BandSaw Machine has started.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("BandSaw Machine has stopped.");
            return true;
        }
    }
}
