using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Turbo
    {
        int price;
        double speed, acceleration;
        string name;

        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public double Speed { get { return speed; } set { speed = value; } }
        public double Acceleration { get { return acceleration; } set { acceleration = value; } }

        public Turbo(string name, int price, double speed, double acceleration)
        {
            this.name = name;
            this.price = price;
            this.speed = speed;
            this.acceleration = acceleration;
        }

        public static bool TurboBoost()
        {
            return false;
        }
    }
}
