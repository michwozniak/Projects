using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public abstract class Statistics
    {
        public double Speed { get; set; } 
        public double Control { get; set; }
        public double Acceleration { get; set; }
        public double Braking { get; set; }
        public int Price { get; set; }
        public int numberOfRaces { get; set; }
        public int Exp { get; set; }
        public int Lvl { get; set; }
        public int Money { get; set; }
        public string Name { get; set; }
        public string carName { get; set; }
    }
}
