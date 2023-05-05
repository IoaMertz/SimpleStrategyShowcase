using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStrategy
{
    public interface IContext<T> where T : IStrategy
    {

        T Strategy { get; set; }
        

    }
}
