using KarlMillares.Assessment2.FacadePattern.Contract;
using KarlMillares.Assessment2.FacadePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.FacadePattern
{
    public class StoreFacade
    {
        private IConsole _console;

        public StoreFacade()
        {
            _console = new GameConsole();
        }

        public void GetConsole()
        {
            _console.GetConsole();
        }

        public void GetPackagedConsole()
        {
            _console.GetPackagedConsole();
        }
    }
}
