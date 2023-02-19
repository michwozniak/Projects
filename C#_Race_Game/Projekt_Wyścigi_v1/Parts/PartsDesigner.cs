using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public abstract class PartsDesigner
    {
        abstract public Engine CreateEngine(string name, int price, double speed, double acceleraton);
        abstract public Turbo CreateTurbo(string name, int price, double speed, double acceleraton);
        abstract public Tires CreateTires(string name, int price, double control, double acceleraton, double tireLife);
        abstract public Brakes CreateBrakes(string name, int price, double braking, double control);
    }
}
