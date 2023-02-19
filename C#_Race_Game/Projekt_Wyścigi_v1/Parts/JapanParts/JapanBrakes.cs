using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class JapanBrakes : Brakes
    {
        static int Chance = 6;

        public JapanBrakes(string Name, int Price, double Braking, double Control) : base(Name, Price, Braking, Control) { }

        public override string ToString()
        {
            return base.ToString().Replace("Projekt_Wyścigi_v1.", " ") + "  |  Price: " + Price + "  |  Braking: " + Braking + "\n Acceleration: " + Control + "  |  Chance of accdent: " + Chance + "%\n-----------------------------------------------------------";
        }
        public new static bool BrakesProblem()
        {
            Random rand = new Random();
            double Rand = rand.Next(1, 100);
            //Console.WriteLine(" B:" + Rand);
            //Console.ReadLine();
            if (Rand <= Chance)
            {
                return true;
            }
            return false;
        }

    }
}
