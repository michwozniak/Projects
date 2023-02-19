using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public abstract class TypeOfCars
    {
        public int Price { get; set; }
        public double Speed { get; set; }
        public double Control { get; set; }
        public double Acceleration { get; set; }
        public double Braking { get; set; }
        public string Name { get; set; }
        public static int Number { get; set; }
        public virtual void InitializationOfStatistics(TypeOfCars C) { }
    }
}
