using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMine
{
    public interface IOperation
    {
        int Operation(int a, int b);

    }
}
