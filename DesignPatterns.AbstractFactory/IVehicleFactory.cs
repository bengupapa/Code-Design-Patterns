using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IVehicleFactory
    {
        IVehicle BuildSportsCar();
        IVehicle BuildHatchBack();
    }

    public sealed class VWFactory : IVehicleFactory
    {
        public IVehicle BuildHatchBack()
        {
            return new SportsCar("VW Golf R", 4, new HydrolicBrakes());
        }

        public IVehicle BuildSportsCar()
        {
            return new HatchBack("VW Polo TSI", 4, new ABSBrakes());
        }
    }

    public sealed class ToyotaFactory : IVehicleFactory
    {
        public IVehicle BuildHatchBack()
        {
            return new SportsCar("Toyota RX8", 4, new ABSBrakes());
        }

        public IVehicle BuildSportsCar()
        {
            return new HatchBack("Toyota Corolla", 4, new ABSBrakes());
        }
    }
}
