using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace C16_Abstract_2.Models
{
    class TempSensor : Device
    {
        public override string CreateFormConnectionString(string connectionstring)
        {
            var response = base.CreateFormConnectionString(connectionstring);
            response += " - Device Connected";
            return response;
        }

        public override string ReceiveMessage()
        {
            var message = JsonConvert.DeserializeObject<dynamic>("{ \"command\": \"get\" }");
            return message.command;
        }

        public override void SendMessage(string payload)
        {
            Console.WriteLine($"Sending message: {payload}");
        }
    }
}
