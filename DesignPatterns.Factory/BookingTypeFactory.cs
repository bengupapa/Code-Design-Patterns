using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public static class BookingTypeFactory
    {
        public static FBooking CreateBookingType(int type)
        {
            BookingTypeEnum bookingType = (BookingTypeEnum)type;
            switch (bookingType)
            {
                case BookingTypeEnum.Flight: return new Flight(5640, ApprovalStatusEnum.Approved);
                case BookingTypeEnum.Hotel: return new Hotel(860, ApprovalStatusEnum.Booked);
                case BookingTypeEnum.Car: return new Car(1230, ApprovalStatusEnum.Cancelled);
                default: throw new ArgumentException("Unknown booking type");
            }
        }
    }
}
