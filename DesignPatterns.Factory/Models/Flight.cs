using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Flight:FBooking
    {
        public Flight(decimal amount, ApprovalStatusEnum status)
        {
            this.bookingType = (int)BookingTypeEnum.Flight;
            this.amount = amount;
            this.approvalStatus = (int)status;
        }
    }
}
