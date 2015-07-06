using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public abstract class Booking
    {
        public int bookingType { get; set; }
        public Traveller traveller { get; set; }
        public double bookingAmount { get; set; }
        public IReprice RepriceAbility {get; set; }

        public override string ToString()
        {
            return ((bookingTypeEnum)bookingType).ToString() 
                + " booked for " + traveller.ToString() 
                + " for " + bookingAmount.ToString("C") 
                + " and has reprice " 
                + RepriceAbility.updatePrice(); 
        }
    }

    public class Traveller
    {
        public string name {get; private set;}
        public string surname {get; private set;}

        public Traveller(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public override string ToString()
        {
 	        return this.name + " " + this.surname;
        }
    }

    public enum bookingTypeEnum
    {
        Flight = 1,
        Hotel  = 2
    }
    
}
