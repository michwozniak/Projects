using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class UsaEngine : Engine
    {
        static int Chance = 14;

        public UsaEngine(string Name, int Price, double Speed, double Acceleration) : base(Name, Price, Speed, Acceleration) { }

        public override string ToString()
        {
            return base.ToString().Replace("Projekt_Wyścigi_v1.", " ") + "  |  Price: " + Price + "  |  Speed: " + Speed + "\n Acceleration: " + Acceleration + "  |  Chance of accdent: " + Chance + "%\n-----------------------------------------------------------";
        }

        public new static bool EngineProblem()
        {
            Random rand = new Random();
            double Rand = rand.Next(1, 100);
            //Console.WriteLine(" E:" + Rand);
            //Console.ReadLine();
            if(Rand <= Chance)
            {
                return true;
            }
            return false;
        }
    }
}
