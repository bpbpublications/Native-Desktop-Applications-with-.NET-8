using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrincipleDemo.ISP
{
    public interface IVehicle 
    {
        int Capacity();
        string Make();
        bool HasAC();
        bool HasWindShield();
    }

    public class MotorCycle : IVehicle
    {
        public int Capacity()
        {
            return 2;
        }
        public string Make()
        {
            return "Honda";
        }
        public bool HasAC()
        {
            throw new NotImplementedException();
        }
        public bool HasWindShield()
        {
            throw new NotImplementedException();
        }
    }
}
