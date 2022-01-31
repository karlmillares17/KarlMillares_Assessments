using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.AbstractFactory.Contract
{
    public interface ISmartSwitch
    {
        public string TurnOnLight();
        public string TurnOffLight();
    }
}
