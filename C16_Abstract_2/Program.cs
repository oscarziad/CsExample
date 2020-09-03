using C16_Abstract_2.Models;
using System;

namespace C16_Abstract_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempsensor = new TempSensor();

            Console.WriteLine(tempsensor.CreateFormConnectionString("HostName=iot.azure.com;DeviceId=dev1"));
            Console.WriteLine();

            var command = tempsensor.ReceiveMessage();
            Console.WriteLine($"Received Command: {command}");

            switch(command)
            {
                case "get":
                    tempsensor.SendMessage("temperature = 12");
                    break;

                case "reset":
                    tempsensor.SendMessage("device has been reset.");
                    break;

                default:
                    tempsensor.SendMessage("Command not implemented.");
                        break;
            }
        }
    }
}
