using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka
{
    internal interface IOrder
    {
        string Name { get; }
        void OrderType();

    }
}
