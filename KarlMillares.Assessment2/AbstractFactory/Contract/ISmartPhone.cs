using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.AbstractFactory.Contract
{
    public interface ISmartPhone
    {
        public string Call();
        public string Text();
        public string TurnOnLight(ISmartSwitch collaborator);
        public string TurnOffLight(ISmartSwitch collaborator);
    }
}
