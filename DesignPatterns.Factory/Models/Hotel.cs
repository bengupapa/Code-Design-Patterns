using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Hotel: FBooking
    {
         public Hotel(decimal amount, ApprovalStatusEnum status)
        {
            this.bookingType = (int)BookingTypeEnum.Hotel;
            this.amount = amount;
            this.approvalStatus = (int)status;
        }
    }
}
