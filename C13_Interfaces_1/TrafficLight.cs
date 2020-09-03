using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_1
{
    class TrafficLight : ITrafficLights
    {
        public Guid Id { get; set; }
        public string Location { get; set; }

        public void ChangeLight()
        {
            throw new NotImplementedException();
        }

        public void WarningLight()
        {
            throw new NotImplementedException();
        }
    }
}
