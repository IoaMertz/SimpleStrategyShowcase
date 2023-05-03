using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMine
{
    public class Multiply : IOperation
    {
        public int Operation(int a, int b)
        {
            return a * b;
        }
    }
}
