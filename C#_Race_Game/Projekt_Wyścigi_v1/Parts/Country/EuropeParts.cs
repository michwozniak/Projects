using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class EuropeParts : PartsDesigner
    {
        public override Engine CreateEngine(string Name, int Price, double Speed, double Acceleration)
        {
            EuropeEngine europeEngine = new EuropeEngine(Name, Price, Speed, Acceleration);

            return europeEngine;
        }

        public override Brakes CreateBrakes(string Name, int Price, double Braking, double Control)
        {
            EuropeBrakes europeBrakes = new EuropeBrakes(Name, Price, Braking, Control);

            return europeBrakes;
        }

        public override Tires CreateTires(string Name, int Price, double Control, double Acceleration, double TireLife)
        {
            EuropeTires europeTires = new EuropeTires(Name, Price, Control, Acceleration, TireLife);

            return europeTires;
        }

        public override Turbo CreateTurbo(string Name, int Price, double Speed, double Acceleration)
        {
            EuropeTurbo europeTurbo = new EuropeTurbo(Name, Price, Speed, Acceleration);

            return europeTurbo;
        }
    }
}