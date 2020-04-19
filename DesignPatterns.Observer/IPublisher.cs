using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface IPublisher
    {
        void RegisterObserver(ISubscriber observer);
        void DeregisterObserver(ISubscriber observer);
        int Publish();
    }
}
