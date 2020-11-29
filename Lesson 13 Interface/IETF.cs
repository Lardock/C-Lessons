using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    interface IETF:ISecurities
    {
        string Currency { get; set; }
        void Set(string type, string group, string name, string ticker, decimal price, int quantity);
    }
}
