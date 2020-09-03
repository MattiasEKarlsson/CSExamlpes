using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstruct_2.Models
{
    class TempSensor : Device
    {
        public override string RecevingMesage()
        {
            var message = JsonConvert.DeserializeObject<dynamic>("{\"command\": \"get\"}");
            return message.command;
        }

        public override void SendMessage(string payload)
        {
            Console.WriteLine($"Sending message: {payload}");
        }
    }
}
