using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Car : FBooking
    {
        public Car(decimal amount, ApprovalStatusEnum status)
        {
            this.bookingType = (int)BookingTypeEnum.Car;
            this.amount = amount;
            this.approvalStatus = (int)status;
        }
    }
}
