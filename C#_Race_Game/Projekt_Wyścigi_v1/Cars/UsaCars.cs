using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class UsaCars : TypeOfCars
    {
        public UsaCars(int price, string name, double speed, double acceleration, double control, double braking)
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
            return " Model: " + Name + "  <- USA Car  ~~ Price: " + Price + " \n Top Speed: " + Speed + "  Control: " + Control + "\n Acceleration: " + Acceleration + "  Braking: " + Braking;
        }

        public override void InitializationOfStatistics(TypeOfCars C)
        {
            C.Braking *= 0.05;
        }
        public static UsaCars GenerateUsaCars()
        {
            UsaCars UsaCars_1 = new UsaCars(2200, "Ford Mustang", 3.34, 2.87, 2.11, 1.53);
            UsaCars UsaCars_2 = new UsaCars(2800, "Chevrolet Corvette", 4.23, 3.52, 2.33, 2.16);
            UsaCars UsaCars_3 = new UsaCars(1600, "Doge RAM", 1.63, 2.33, 2.15, 1.76);
            UsaCars UsaCars_4 = new UsaCars(1200, "Jeep Wrangler", 1.45, 1.72, 1.41, 1.87);
            UsaCars UsaCars_5 = new UsaCars(2600, "Tesla Model S", 4.76, 2.16, 2.45, 2.52);
            UsaCars ComeBack = new UsaCars(0, "", 0, 0, 0, 0);
            List<UsaCars> UsaCarsList = new List<UsaCars>();
            UsaCarsList.Add(UsaCars_1);
            UsaCarsList.Add(UsaCars_2);
            UsaCarsList.Add(UsaCars_3);
            UsaCarsList.Add(UsaCars_4);
            UsaCarsList.Add(UsaCars_5);

            int i = 1;
            foreach (UsaCars X in UsaCarsList)
            {
                Console.WriteLine(X.ToString() + "             " + "Number> " + i + "\n-----------------------------------------------------------");
                i++;
            }

            UsaCars[] UsaCarsTab = { UsaCars_1, UsaCars_2, UsaCars_3, UsaCars_4, UsaCars_5, ComeBack };
            return ChooseUsaCars(UsaCarsTab);
        }

        public static UsaCars ChooseUsaCars(UsaCars[] D)
        {
            Console.WriteLine("Choose a USA Car 1-5 and press the number: \nBACK -> Press ENTER");
            string enter = Console.ReadLine();
            if (enter == "") { Number = 0; }
            else { 
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
