using KarlMillares.Assessment2.FacadePattern.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.FacadePattern.Implementation
{
    public class GameConsole: IConsole
    {
        public void GetConsole()
        {
            Console.WriteLine("Getting console only.");
        }

        public void GetPackagedConsole()
        {
            Console.WriteLine("Getting packaged console");
            GetPackage();
        }

        private void GetPackage()
        {
            Console.WriteLine("Getting games and additional controller");
        }
    }
}
