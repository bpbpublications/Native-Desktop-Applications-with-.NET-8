﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.OCP
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
    }

    public class MyVehicle
    {
        public List<Vehicle> GetCars()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            // fetch all the vehciles of type car

            return vehicles;
        }
    }
}
