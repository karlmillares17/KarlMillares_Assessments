using KarlMillares.Assessment2.AbstractFactory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.AbstractFactory.Implementation
{
    public class SmartDevice : ISmartDevices
    {
        public ISmartSwitch CreateSwitch()
        {
            return new SmartSwitch();
        }

        public ISmartPhone CreatePhone()
        {
            return new SmartPhone();
        }
    }
}
