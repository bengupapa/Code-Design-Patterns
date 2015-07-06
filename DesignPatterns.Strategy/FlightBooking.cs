using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class FlightBooking:Booking
    {
        public FlightBooking(Traveller newTraveller)
        {
            this.bookingType = (int)bookingTypeEnum.Flight;
            this.bookingAmount = 1250.00;
            this.RepriceAbility = new hasReprice();
            this.traveller = newTraveller;
        }
    }
}
