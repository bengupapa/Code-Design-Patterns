using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public interface IRepriceStrategy
    {
        bool updatePrice();
    }

    public class HasRepriceStrategy: IRepriceStrategy
    {
        public bool updatePrice()
        {
            return true;
        }
    }

    public class NoRepriceStrategy: IRepriceStrategy
    {
        public bool updatePrice()
        {
            return false;
        }
    }
}
