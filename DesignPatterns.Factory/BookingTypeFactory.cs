using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public static class BookingTypeFactory
    {
        public static FBooking makeBooking(int type)
        {
            if (type == (int)BookingTypeEnum.Flight)

                return new Flight(5640, ApprovalStatusEnum.Approved);

            else if (type == (int)BookingTypeEnum.Hotel)

                return new Hotel(860, ApprovalStatusEnum.Booked);

            else if (type == (int)BookingTypeEnum.Car)

                return new Car(1230, ApprovalStatusEnum.Cancelled);

            else
                return null;
        }
    }
}
