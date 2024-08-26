using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.DIP1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VehicleBusinessLogic vehicleBusinessLogic = new VehicleBusinessLogic();
            vehicleBusinessLogic.CreateVehcile();
        }
    }

    public class Vehicle
    {
        public string VIN { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class VehicleBusinessLogic
    {
        VehicleDataLogic vehicleDataLogic = null;
        public VehicleBusinessLogic()
        {
            vehicleDataLogic = new VehicleDataLogic();
        }

        public bool CreateVehicle()
        {
            Vehicle vehicle = new()
            {
                VIN = "12345",
                Name = "Honda City",
                Type = "Car"
            };

            return vehicleDataLogic.CreateVehicle(vehicle);
        }
    }

    public class VehicleDataLogic
    {
        public VehicleDataLogic() { }

        public bool CreateVehicle(Vehicle vehicle)
        {
            if(vehicle != null)
            {
                //Need to save the vehicle to the datastore
            }

            return true;
        }
    }
}
