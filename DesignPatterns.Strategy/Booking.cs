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
        public IRepriceStrategy RepriceAbility {get; set; }

        public override string ToString()
        {
            var str = new StringBuilder(((bookingTypeEnum)bookingType).ToString());
            str.Append(" booked for ")
                .Append(traveller)
                .Append(" for ")
                .Append(bookingAmount.ToString("C"))
                .Append(" and has reprice ")
                .Append(RepriceAbility.updatePrice());

            return str.ToString();
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
