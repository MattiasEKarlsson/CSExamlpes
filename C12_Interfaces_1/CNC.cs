using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class CNC : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("CNC starting.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("CNC stoping.");
            return false;
        }
    }
}
