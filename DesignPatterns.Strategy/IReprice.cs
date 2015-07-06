using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public interface IReprice
    {
        bool updatePrice();
    }

    public class hasReprice: IReprice
    {
        public bool updatePrice()
        {
            return true;
        }
    }

    public class noReprice: IReprice
    {
        public bool updatePrice()
        {
            return false;
        }
    }
}
