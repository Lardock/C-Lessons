using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class ShowAllSecurities<T>
        where T:Securities
    {
        public void Show(T securities)
        {
            Console.WriteLine($"Type {securities.Type,-10} Name {securities.Name,-15} Ticker {securities.Type,-10} Price {securities.Price,-8}");
        }
    }
}
