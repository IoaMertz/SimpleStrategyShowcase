using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMine
{
    public class Calculator  // Context
    {
        public IOperation operation { get; set; }

        public int PerformOperation(int a , int b)
        {
            return operation.Operation(a,b);
        }

    }
}
