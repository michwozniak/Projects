using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Brakes
    {
        int price;
        double braking, control;
        string name;

        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public double Braking { get { return braking; } set { braking = value; } }
        public double Control { get { return control; } set { control = value; } }

        public Brakes(string name, int Price, double Braking, double Control)
        {
            this.name = name;
            this.price = Price;
            this.braking= Braking;
            this.control = Control;
        }

        public static bool BrakesProblem()
        {
            return false;
        }
    }
}
