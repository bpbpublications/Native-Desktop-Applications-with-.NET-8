using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.DemoLSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IVehicle vehicle_car = new Car();
            Console.WriteLine($"Capacity of car is: {vehicle_car?.Capacity()}");

            IVehicle vehicle_mc = new MotorCycle();
            Console.WriteLine($"Capacity of car is: {vehicle_mc?.Capacity()}");

            Console.ReadKey();
        }
    }

    public interface IVehicle
    {
        int Capacity();
    }

    public class Car : IVehicle
    {
        public int Capacity()
        {
            return 4;
        }
    }

    public class MotorCycle : IVehicle
    {
        public int Capacity()
        {
            return 2;
        }
    }
}
