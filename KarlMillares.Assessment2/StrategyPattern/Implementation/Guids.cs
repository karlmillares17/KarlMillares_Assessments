using KarlMillares.Assessment2.StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.StrategyPattern.Implementation
{
    public class Guids: GenerateStrategy
    {
        public override void Generate()
        {
            Console.WriteLine($"Generated Guid: {Guid.NewGuid()}");
        }
    }
}
