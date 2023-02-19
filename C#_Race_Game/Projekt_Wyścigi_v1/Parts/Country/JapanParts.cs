using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class JapanParts : PartsDesigner
    {
        public override Engine CreateEngine(string Name, int Price, double Speed, double Acceleration)
        {
            JapanEngine japanEngine = new JapanEngine(Name, Price, Speed, Acceleration);

            return japanEngine;
        }

        public override Brakes CreateBrakes(string Name, int Price, double Braking, double Control)
        {
            JapanBrakes japanBrakes = new JapanBrakes(Name, Price, Braking, Control);

            return japanBrakes;
        }

        public override Tires CreateTires(string Name, int Price, double Control, double Acceleration, double TireLife)
        {
            JapanTires japanTires = new JapanTires(Name, Price, Control, Acceleration, TireLife);

            return japanTires;
        }

        public override Turbo CreateTurbo(string Name, int Price, double Speed, double Acceleration)
        {
            JapanTurbo japanTurbo = new JapanTurbo(Name, Price, Speed, Acceleration);

            return japanTurbo;
        }
    }
}
