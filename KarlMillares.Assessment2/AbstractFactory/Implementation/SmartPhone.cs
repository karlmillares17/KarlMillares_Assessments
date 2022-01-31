using KarlMillares.Assessment2.AbstractFactory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.AbstractFactory.Implementation
{
    public class SmartPhone: ISmartPhone
    {
        public string Call()
        {
            return "Call some using phone";
        }

        public string Text()
        {
            return "Text some using phone";
        }

        public string TurnOnLight(ISmartSwitch collaborator)
        {
            var result = collaborator.TurnOnLight();
            return $"Called switch to turn on light {result}";
        }

        public string TurnOffLight(ISmartSwitch collaborator)
        {
            var result = collaborator.TurnOffLight();
            return $"Called switch to turn off light {result}";
        }
    }
}
