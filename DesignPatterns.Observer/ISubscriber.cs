using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface ISubscriber
    {
        void Update(double imb, double mcsoft, double nas);
    }
}
