using KarlMillares.Assessment2.StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.StrategyPattern.Implementation
{
    public class Numbers: GenerateStrategy
    {
        public override void Generate()
        {
            var randomNumber = new Random().Next(100000, 500000);
            Console.WriteLine($"Generated Number: {randomNumber}");
        }
    }
}
