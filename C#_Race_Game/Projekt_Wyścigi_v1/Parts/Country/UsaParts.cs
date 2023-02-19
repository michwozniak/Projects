using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class UsaParts : PartsDesigner
    {
        public override Engine CreateEngine(string Name, int Price, double Speed, double Acceleration)
        {
            UsaEngine usaEngine = new UsaEngine(Name, Price, Speed, Acceleration);

            return usaEngine;
        }

        public override Brakes CreateBrakes(string Name, int Price, double Braking, double Control)
        {
            UsaBrakes usaBrakes = new UsaBrakes(Name, Price, Braking, Control);

            return usaBrakes;
        }

        public override Tires CreateTires(string Name, int Price, double Control, double Acceleration, double TireLife)
        {
            UsaTires usaTires = new UsaTires(Name, Price, Control, Acceleration, TireLife);

            return usaTires;
        }

        public override Turbo CreateTurbo(string Name, int Price, double Speed, double Acceleration)
        {
            UsaTurbo usaTurbo = new UsaTurbo(Name, Price, Speed, Acceleration);

            return usaTurbo;
        }
    }
}
