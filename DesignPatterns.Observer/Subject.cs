using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Subject: IPublisher
    {
        private List<ISubscriber> Observers;
        public double imbStock = 0;
        public double mcsoftStock = 0;
        public double nasStock = 0;

        public Subject()
        {
            Observers = new List<ISubscriber>();
        }

        public void registerObserver(ISubscriber observer)
        {
            Observers.Add(observer);
        }

        public void unregisterObserver(ISubscriber observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        public int publish()
        {
            Observers.ForEach(o => o.update(imbStock, mcsoftStock, nasStock));
            return Observers.Count();
        }
    }
}
