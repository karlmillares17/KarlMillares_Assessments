using KarlMillares.Assessment2.AbstractFactory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.AbstractFactory.Implementation
{
    public class SmartSwitch : ISmartSwitch
    {
        public string TurnOnLight()
        {
            return "Turn on light using switch";
        }

        public string TurnOffLight()
        {
            return "Turn off light using switch";
        }
    }
}
