using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StackObject<T>
    {

        public T Content { get; set; }

        public StackObject<T> Below { get; set; }
        
    }
}
