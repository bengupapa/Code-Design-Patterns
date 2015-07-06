using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class HotelBooking : Booking
    {
        public HotelBooking(Traveller newTraveller)
        {
            this.bookingType = (int)bookingTypeEnum.Hotel;
            this.traveller = newTraveller;
            this.bookingAmount = 986.00;
            this.RepriceAbility = new noReprice();
        }

    }
}
