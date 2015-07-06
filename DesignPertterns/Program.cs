using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy;
using DesignPatterns.Observer;
using DesignPatterns.Factory;

namespace DesignPertterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBSERVER
            executeStrategyDesignPattern();

            //OSERVER PATTERN
            executeObserverDesignPattern();

            //FACTORY PATTERN
            executeFactoryDesignParttern();

            Console.Read();
        }

        /// <summary>
        /// Use strategy pattern: When you want to define d a class that will have one behaviour that is similar to other behaviour in a list
        /// Advantages:
        /// -Reduces long list of conditionals
        /// -Avaoid duplicate code
        /// -Keeps class changes from forcing other class changes
        /// -Can hide complicated  secret code from the user
        /// Disadvantage: 
        /// -Increased number of object/ classes
        /// </summary>
        private static void executeStrategyDesignPattern()
        {
            Console.WriteLine("STRATEGY PATTERN \n");

            Booking hotel = new HotelBooking(new Traveller("Papa", "Bengu"));
            Booking flight = new FlightBooking(new Traveller("Dikeledi", "Ngqwemla"));


            Console.WriteLine(hotel.ToString());
            Console.WriteLine("");
            Console.WriteLine(flight.ToString());

            Console.WriteLine("------------------- \n");
        }

        /// <summary>
        /// DEFINITION
        /// - Software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, 
        /// and notifies them automatically of any state changes, ussually calling one of their methods.
        /// USAGE
        /// -When you need many other objects to recieve an update when another objecy changes
        /// -Publisher Subject sends many data to Observers
        /// -Observers Subscribers take the data they want and use it.
        /// ADVANTAGES
        /// -Loose coupling
        /// -Publisher doen't need to know anything about the Subscribers
        /// DISADVANTAGES
        /// -Publisher may send updates that don't matter to the subscriber
        /// </summary>
        private static void executeObserverDesignPattern()
        {
            Console.WriteLine("OBSERVER PATTERN \n");

            IPublisher publisher = new Subject()
            {
                imbStock = 8000,
                mcsoftStock = 6500,
                nasStock = 5760
            };

            ISubscriber dikeledi = new Observer(publisher);
            ISubscriber papa = new Observer(publisher);

            Console.WriteLine("\n Published to {0} observers \n", publisher.publish());

            ((Subject)publisher).imbStock = 1000.02;

            ISubscriber madillo = new Observer(publisher);
            ISubscriber nozy = new Observer(publisher);
            publisher.unregisterObserver(dikeledi);

            Console.WriteLine("\n Published to {0} observers \n", publisher.publish());

            Console.WriteLine("------------------- \n");
        }

        /// <summary>
        /// DEFINITION
        /// -Software design pattern that allow for creation of an object without knowledge of the class of the object
        /// -When a method returns one of several possible classes that share a common siper class
        /// USAGE
        /// -When you don't know ahead of time what class object yo need
        /// -When all of the potential classes are in the same subclass heirarchy
        /// -To centralize class selection code
        /// -When you don;t want the user ti have to know every subclass
        /// -To encapsulate object creation
        /// </summary>
        private static void executeFactoryDesignParttern()
        {

            Console.WriteLine("FACTORY PATTERN \n");

            Console.WriteLine(BookingTypeFactory.makeBooking(1).ToString() + "\n");
            Console.WriteLine(BookingTypeFactory.makeBooking(2).ToString() + "\n");
            Console.WriteLine(BookingTypeFactory.makeBooking(3).ToString() + "\n");

            Console.WriteLine("------------------- \n");
        }
    }
}
