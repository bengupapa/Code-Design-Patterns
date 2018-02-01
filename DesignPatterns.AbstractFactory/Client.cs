using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Client
    {
        public List<IVehicle> BuilderCars()
        {
            IVehicleFactory toyotaFatcory = new ToyotaFactory();
            IVehicleFactory vwFactory = new VWFactory();

            return new List<IVehicle>
            {
                toyotaFatcory.BuildSportsCar(),
                toyotaFatcory.BuildHatchBack(),
                vwFactory.BuildSportsCar(),
                vwFactory.BuildHatchBack()
            };
        }
    }
}
