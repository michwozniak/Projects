using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Tires
    {
        int price;
        double control, tireLife, acceleration;
        string name;

        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public double Control { get { return control; } set { control = value; } }
        public double Acceleration { get { return acceleration; } set { acceleration = value; } }
        public double TireLife { get { return tireLife; } set { tireLife = value; } }

        public Tires(string name, int price, double control, double acceleration, double tireLife)
        {
            this.name = name;
            this.price = price;
            this.control = control;
            this.acceleration = acceleration;
            this.tireLife = tireLife;
        }

        public static double FlatTire(double TireLife)
        {
            return (TireLife - 26);
        }
    }
}
