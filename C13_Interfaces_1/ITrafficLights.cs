using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_1
{
    interface ITrafficLights
    {

        enum Color
        {
            Green,
            Yellow,
            Red
        }

        Guid Id { get; set; }
        string Location { get; set; }

        void ChangeLight();
        void WarningLight();
    }
}
