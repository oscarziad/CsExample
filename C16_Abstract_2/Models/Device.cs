using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C16_Abstract_2.Models
{
    abstract class Device
    {
        public virtual string CreateFormConnectionString(string connectionstring)
        {
            return $"Initializing connection \"{connectionstring}\"";
        }

        public abstract string ReceiveMessage();
        public abstract void SendMessage(string payload);
    }
}
 