using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.ISP1
{
    public interface IFourWheelerVehicle
    {
        int Capacity();
        string Make();
        bool HasAC();
        bool HasWindShield();
    }
    public interface ITwoWheelerVehicle
    {
        int Capacity();
        string Make();
    }

    public class MotorCycle : ITwoWheelerVehicle
    {
        public int Capacity()
        {
            return 2;
        }
        public string Make()
        {
            return "Honda";
        }
    }
}
