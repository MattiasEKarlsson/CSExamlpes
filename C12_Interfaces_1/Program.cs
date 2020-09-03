using System;

namespace C12_Interfaces_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cnc = new CNC();
            cnc.Start();

            var band = new BandSaw();
            band.Start();
            band.Stop();
            cnc.Start();
            cnc.Stop();

            
        }
    }
}
