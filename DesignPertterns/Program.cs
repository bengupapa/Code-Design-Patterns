using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy;
using DesignPatterns.Observer;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Interfaces;
using DesignPatterns.Builder.Models;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Prototype;

namespace DesignPertterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACT FACTORY PATTERN
            ExecuteAbstractFactoryDesignPattern();

            //BUILDER PATTERN
            ExecuteBuilderDesignPattern();

            //FACTORY PATTERN
            ExecuteFactoryDesignParttern();

            //OSERVER PATTERN
            ExecuteObserverDesignPattern();

            //SINGLETON PATTERN
            ExecuteSingletonDesignParttern();

            //STRATEGY PATTERN
            ExecuteStrategyDesignPattern();

            //PROTOTYPE PATTERN
            ExecutePrototyDesignPattern();

            Console.Read();
        }

        /// <summary>
        /// Use singleton pattern: When you want to eliminate the option of instantiating more than one object
        /// Advantages:
        /// -
        /// </summary>
        private static void ExecuteSingletonDesignParttern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("SINGLETON PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

            var BaseClass = BaseManager.Instance;

            BaseClass.Players.ForEach(p =>
            {
                Console.WriteLine("Name : " + p.PlayerName + " Games : " + p.GetGamesPlayed() + " Salary: " + p.Remuneration);

                //Change set 1 on the initial instance
                p.SetRemuneration(1000750);
            });

            //Change set 2 on the initial instance
            var player = BaseClass.Players.SingleOrDefault(p => p.PlayerName == "Papa Bengu");
            BaseClass.Players.Remove(player);

            Console.WriteLine("\n");
            Console.WriteLine("After getting new instance \n");

            //Idealy getting a new instance. Change set 1 and 2 should not available on this new instance
            var BaseClass2 = BaseManager.Instance;

            BaseClass.Players.ForEach(p =>
            {
                Console.WriteLine("Name : " + p.PlayerName + " Games : " + p.GetGamesPlayed() + " Salary: " + p.Remuneration);
            });

            Console.WriteLine("------------------- \n");
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
        private static void ExecuteStrategyDesignPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("STRATEGY PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

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
        private static void ExecuteObserverDesignPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("OBSERVER PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

            IPublisher publisher = new Subject()
            {
                imbStock = 8000,
                mcsoftStock = 6500,
                nasStock = 5760
            };

            ISubscriber dikeledi = new Observer(publisher);
            ISubscriber papa = new Observer(publisher);

            Console.WriteLine("\n Published to {0} observers \n", publisher.Publish());

            ((Subject)publisher).imbStock = 1000.02;

            ISubscriber madillo = new Observer(publisher);
            ISubscriber nozy = new Observer(publisher);
            publisher.DeregisterObserver(dikeledi);

            Console.WriteLine("\n Published to {0} observers \n", publisher.Publish());

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
        private static void ExecuteFactoryDesignParttern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("FACTORY PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(BookingTypeFactory.CreateBookingType(1).ToString() + "\n");
            Console.WriteLine(BookingTypeFactory.CreateBookingType(2).ToString() + "\n");
            Console.WriteLine(BookingTypeFactory.CreateBookingType(3).ToString() + "\n");

            Console.WriteLine("------------------- \n");
        }

        private static void ExecuteBuilderDesignPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("BUILDER PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

            IMatterBuilder builder = new BondBuilder();
            MatterBuilderDirector Director = new MatterBuilderDirector(builder);

            IMatter bond = Director.ConstructMatter();

            Console.WriteLine("MORTGAGORS: {0}", String.Join("; ", bond.Morgagors.ToArray()));
            Console.WriteLine("PARTIES: {0}", String.Join("; ", bond.Parties.ToArray()));
            Console.WriteLine("PROPERTIES: {0}", String.Join("; ", bond.Properties.ToArray()));

            Console.WriteLine("FINANCIALS: ");
            bond.Financials.ToList().ForEach(fin =>
            {
                Console.WriteLine($"{fin.Key} : {fin.Value}");
            });

            Console.WriteLine("------------------- \n");
        }

        private static void ExecuteAbstractFactoryDesignPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("ABSTRACTOR PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

            var client = new Client();

            client.BuilderCars().ForEach(car =>
            {
                Console.WriteLine($"{car.Make} => {car.WheelBase} wheels => {car.Brake()}");
            });

            Console.WriteLine("------------------- \n");
        }

        public static void ExecutePrototyDesignPattern()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PROTOTYPE PATTERN \n");
            Console.ForegroundColor = ConsoleColor.White;

            var sheep = new Animal() { Name = "Sheepy" };
            var cloner = new Cloner();
            var dolly = cloner.Clone<Animal>(sheep);

            Console.WriteLine($"{sheep.Name} at {sheep.GetHashCode()}");
            Console.WriteLine($"{dolly.Name} at {dolly.GetHashCode()}");

            Console.WriteLine("------------------- \n");
        }
    }
}
