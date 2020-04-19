using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Observer : ISubscriber
    {
        IPublisher subject;
        public static int CONSTANTID = 0;
        int observerId;
        double imbStock = 0;
        double mcsoftStock = 0;
        double nasStock = 0;

        public Observer(IPublisher subject)
        {
            this.subject = subject;
            this.observerId = ++CONSTANTID;

            subject.RegisterObserver(this);
        }

        public void Update(double imb, double mcsoft, double nas)
        {
            this.imbStock = imb;
            this.mcsoftStock = mcsoft;
            this.nasStock = nas;

            Console.WriteLine("{0} \n IMB {1} \n MCSoft {2} \n Naspers {3}"
                , this.observerId
                , this.imbStock
                , this.mcsoftStock
                , this.nasStock);
        }
    }
}
