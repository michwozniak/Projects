using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class EuropeCars : TypeOfCars
    {
        public EuropeCars(int price, string name, double speed, double acceleration, double control, double braking)
        {
            Price = price;
            Name = name;
            Speed = speed;
            Acceleration = acceleration;
            Control = control;
            Braking = braking;
        }

        public override string ToString()
        {
            return " Model: " + Name + "  <- EUROPE Car  ~~ Price: " + Price + " \n Top Speed: " + Speed + "  Control: " + Control + "\n Acceleration: " + Acceleration + "  Braking: " + Braking;
        }

        public override void InitializationOfStatistics(TypeOfCars C)
        {
            C.Acceleration *= 0.05;
        }

        public static EuropeCars GenerateEuropeCars()
        {
            EuropeCars EuropeCars_1 = new EuropeCars(1200, "Skoda Superb IV", 1.25, 2.54, 1.24, 1.17);
            EuropeCars EuropeCars_2 = new EuropeCars(1900, "Volkswagen Golf 8 R", 3.74, 1.45, 2.27, 1.76);
            EuropeCars EuropeCars_3 = new EuropeCars(2800, "BMW M3 Competition", 4.25, 1.73, 4.45, 2.77);
            EuropeCars EuropeCars_4 = new EuropeCars(2400, "Mercedes G Klasa", 3.31, 2.71, 2.83, 2.53);
            EuropeCars EuropeCars_5 = new EuropeCars(3600, "Mercedes A45 AMG", 4.86, 3.23, 4.11, 3.75);
            EuropeCars ComeBack = new EuropeCars(0, "", 0, 0, 0, 0);

            List<EuropeCars> EuropeCarsList = new List<EuropeCars>();
            EuropeCarsList.Add(EuropeCars_1);
            EuropeCarsList.Add(EuropeCars_2);
            EuropeCarsList.Add(EuropeCars_3);
            EuropeCarsList.Add(EuropeCars_4);
            EuropeCarsList.Add(EuropeCars_5);

            int i = 1;
            foreach (EuropeCars X in EuropeCarsList)
            {
                Console.WriteLine(X.ToString() + "             " + "Number> " + i + "\n-----------------------------------------------------------");
                i++;
            }

            EuropeCars[] EuropeCarsTab = { EuropeCars_1, EuropeCars_2, EuropeCars_3, EuropeCars_4, EuropeCars_5, ComeBack };
            return ChooseEuropeCars(EuropeCarsTab);
        }

        public static EuropeCars ChooseEuropeCars(EuropeCars[] D)
        {
            Console.WriteLine("Choose a Europe Car 1-5 and press the number: \nBACK -> Press ENTER");
            string enter = Console.ReadLine();
            if (enter == "") { Number = 0; }
            else
            {
                Number = int.Parse(enter);
            }

            while (Number < 0 || Number > 5)
            {
                Console.WriteLine("Wrong number!");
                Number = int.Parse(Console.ReadLine());
            }

            switch (Number)
            {
                case 0:
                    break;
                case 1:
                    return D[0];
                case 2:
                    return D[1];
                case 3:
                    return D[2];
                case 4:
                    return D[3];
                case 5:
                    return D[4];
                default:
                    Console.WriteLine("WRONG NUMBER !");
                    break;
            }
            return D[5];
        }
    }
}
