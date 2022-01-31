using KarlMillares.Assessment2.AbstractFactory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.AbstractFactory
{
    public class Client
    {
        public void ClientMethod(ISmartDevices smartDevices)
        {
            var smartSwitch = smartDevices.CreateSwitch();
            var smartPhone = smartDevices.CreatePhone();

            Console.WriteLine(smartSwitch.TurnOnLight());
            Console.WriteLine(smartPhone.Call());
            Console.WriteLine(smartPhone.TurnOffLight(smartSwitch));
        }
        

    }
}
