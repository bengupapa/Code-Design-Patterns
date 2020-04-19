using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public abstract class FBooking
    {
        public int bookingType { get; set; }
        public int approvalStatus { get; set; }
        public decimal amount { get; set; }

        public override string ToString()
        {
            return String.Format("{0} Booking was {1} with amount of {2}"
                , ((BookingTypeEnum)bookingType).ToString()
                , ((ApprovalStatusEnum)approvalStatus).ToString()
                , amount.ToString("C"));
        }
    }

    public enum ApprovalStatusEnum
    {
        Booked = 1,
        Approved = 2,
        Cancelled = 3
    }

    public enum BookingTypeEnum
    {
        Flight = 1,
        Hotel = 2,
        Car = 3
    }
}
