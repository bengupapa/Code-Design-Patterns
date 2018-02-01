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

        public void RegisterObserver(ISubscriber observer)
        {
            Observers.Add(observer);
        }

        public void DeregisterObserver(ISubscriber observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        public int Publish()
        {
            Observers.ForEach(o => o.Update(imbStock, mcsoftStock, nasStock));
            return Observers.Count();
        }
    }
}
