using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class JapanTurbo : Turbo
    {
        static int Chance = 10;

        public JapanTurbo(string Name, int Price, double Speed, double Acceleration) : base(Name, Price, Speed, Acceleration) { }

        public override string ToString()
        {
            return base.ToString().Replace("Projekt_Wyścigi_v1.", " ") + "  |  Price: " + Price + "  |  Speed: " + Speed + "\n Acceleration: " + Acceleration + "  |  Event chance: " + Chance + "%\n-----------------------------------------------------------";
        }
        public new static bool TurboBoost()
        {
            Random rand = new Random();
            double Rand = rand.Next(1, 100);
            //Console.WriteLine(" T:" + Rand);
            //Console.ReadLine();
            if (Rand <= Chance)
            {
                return true;
            }
            return false;
        }
    }
}
