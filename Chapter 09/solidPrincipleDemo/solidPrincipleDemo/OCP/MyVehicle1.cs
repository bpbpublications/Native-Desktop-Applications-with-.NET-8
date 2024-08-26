using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.OCP
{
    public interface IVehicle
    {
        List<Vehicle> GetVehicles();
    }

    public class Car : IVehicle
    {
        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            // fetch all the vehciles of type car

            return vehicles;
        }
    }

    public class Van : IVehicle
    {
        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            // fetch all the vehciles of type van

            return vehicles;
        }
    }
}
