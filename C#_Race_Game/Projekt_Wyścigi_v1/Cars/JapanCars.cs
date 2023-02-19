using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class JapanCars : TypeOfCars
    {
        public JapanCars(int price, string name, double speed, double acceleration, double control, double braking)
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
            return " Model: " + Name + "  <- JAPAN Car  ~~ Price: " + Price + " \n Top Speed: " + Speed + "  Control: " + Control + "\n Acceleration: " + Acceleration + "  Braking: " + Braking;
        }

        public override void InitializationOfStatistics(TypeOfCars C)     // Potrzebna funkcja ??
        {
            C.Control *= 0.05;
        }

        public static JapanCars GenerateJapanCars()
        {
            JapanCars JapanCars_1 = new JapanCars(2650, "Nissan Skyline R34 GT-R", 3.74, 3.22, 1.64, 3.14);
            JapanCars JapanCars_2 = new JapanCars(1900, "Honda Civic X", 1.64, 2.25, 1.98, 3.85);
            JapanCars JapanCars_3 = new JapanCars(1600, "Mazda RX-7", 1.66, 1.23, 2.51, 2.75);
            JapanCars JapanCars_4 = new JapanCars(4200, "Toyota Supra", 5.64, 2.14, 2.43, 3.76);
            JapanCars JapanCars_5 = new JapanCars(2100, "Subaru Impreza WRX STI", 2.73, 3.13, 2.55, 1.57);
            JapanCars ComeBack = new JapanCars(0, "", 0, 0, 0, 0);

            List<JapanCars> JapanCarsList = new List<JapanCars>();
            JapanCarsList.Add(JapanCars_1);
            JapanCarsList.Add(JapanCars_2);
            JapanCarsList.Add(JapanCars_3);
            JapanCarsList.Add(JapanCars_4);
            JapanCarsList.Add(JapanCars_5);

            int i = 1;
            foreach (JapanCars X in JapanCarsList)
            {
                Console.WriteLine(X.ToString() + "             " + "Number> " + i + "\n-----------------------------------------------------------");
                i++;
            }

            JapanCars[] JapanCarsTab = { JapanCars_1, JapanCars_2, JapanCars_3, JapanCars_4, JapanCars_5, ComeBack };
            return ChooseJapanCars(JapanCarsTab);
        }

        public static JapanCars ChooseJapanCars(JapanCars[] D)
        {
            Console.WriteLine("Choose a Japan Car 1-5 and press the number: \nBACK -> Press ENTER");
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
