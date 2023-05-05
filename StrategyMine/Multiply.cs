using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMine
{
    public class Multiply : IOperation //strategy2
    {
        public int Operation(int a, int b)
        {
            return a * b;
        }
    }
}
