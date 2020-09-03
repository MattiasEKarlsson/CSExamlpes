using C15_Abstruct_2.Models;
using System;

namespace C15_Abstruct_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var temsensor = new TempSensor();
            temsensor.CreateFromConnectionString("HostName=iot.azure.com;DeviceId=dev1");
            Console.WriteLine();
            var command = temsensor.RecevingMesage();
            Console.WriteLine($"Recived Command: {command}");

            switch (command)
            {
                case "get":
                    temsensor.SendMessage("Temp = 12");
                        break;
                    
            }
        }
    }
}
