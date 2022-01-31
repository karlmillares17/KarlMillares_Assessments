using KarlMillares.Assessment2.StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMillares.Assessment2.StrategyPattern
{
    public class GenerateItem
    {
        private GenerateStrategy _generateStrategy;
        public void SetStrategy(GenerateStrategy generateStrategy)
        {
            this._generateStrategy = generateStrategy;
        }

        public void Generate()
        {
            _generateStrategy.Generate();
        }

    }
}
