using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class UsaTires : Tires
    {
        public UsaTires(string Name, int Price, double Control, double Acceleration, double TireLife) : base(Name, Price, Control, Acceleration, TireLife) {}

        public override string ToString()
        {
            return base.ToString().Replace("Projekt_Wyścigi_v1.", " ") + "  |  Price: " + Price + "  |  Control: " + Control + "\n Acceleration: " + Acceleration + "  |  TireLife: " + TireLife + "%\n-----------------------------------------------------------";
        }

        public static new double FlatTire(double TireLife) 
        {
            return (TireLife - 14);
        }
    }
}