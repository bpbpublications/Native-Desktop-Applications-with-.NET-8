using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.LSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new MotorCycle();

            Console.WriteLine($"Capacity of car is: {car?.Capacity()}");
        }
    }

    public class Car
    {
        public virtual int Capacity()
        {
            return 4;
        }
    }

    public class MotorCycle : Car
    {
        public override int Capacity()
        {
            return 2;
        }
    }
}
