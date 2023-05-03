using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDelegates
{
    public class Calculator
    {
        public delegate int Operation(int a, int b);
        public int PerformOperation(Operation operation , int a , int b) 
        {
             return operation.Invoke(a,b);

        }

    }
}
