using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Models
{
    public interface IVehicle
    {
        string Brake();
        int Accelerate();
        int WheelBase { get; set; }
        string Make { get; set; }
        IBrakeSystem BrakingSystem { get; set; }
    }

    public sealed class SportsCar: IVehicle
    {
        public SportsCar(string make, int wheelBase, IBrakeSystem brakeStrategy)
        {
            this.Make = make;
            this.WheelBase = wheelBase;
            this.BrakingSystem = brakeStrategy;
        }

        public IBrakeSystem BrakingSystem { get; set; }

        public string Make { get; set; }

        public int WheelBase { get; set; }

        public int Accelerate()
        {
            return 360;
        }

        public string Brake()
        {
            return BrakingSystem.ApplyBrakes();
        }
    }

    public sealed class HatchBack : IVehicle
    {
        public HatchBack(string make, int wheelBase, IBrakeSystem brakeStrategy)
        {
            this.Make = make;
            this.WheelBase = wheelBase;
            this.BrakingSystem = brakeStrategy;
        }

        public IBrakeSystem BrakingSystem { get; set; }

        public string Make { get; set; }

        public int WheelBase { get; set; }

        public int Accelerate()
        {
            return 200;
        }

        public string Brake()
        {
            return BrakingSystem.ApplyBrakes();
        }
    }

    public interface IBrakeSystem
    {
        string ApplyBrakes();
    }

    public sealed class HydrolicBrakes : IBrakeSystem
    {
        public string ApplyBrakes()
        {
            return "Braked using hydrolics";
        }
    }

    public sealed class ABSBrakes : IBrakeSystem
    {
        public string ApplyBrakes()
        {
            return "Braked using Anti-skid/locking";
        }
    }
}
