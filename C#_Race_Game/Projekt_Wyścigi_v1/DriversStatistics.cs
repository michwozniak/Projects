using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class DriversStatistics : Statistics
    {
        double driverPower;
        public static int Number { get; set; }

        public DriversStatistics(string name, double speed, double acceleration, double control, double braking)
        {
            Name = name;
            Speed = speed;
            Acceleration = acceleration;
            Control = control;
            Braking = braking;
            driverPower = DriverPower(Speed, Acceleration, Control, Braking);   
        }

        public double DriverPower(double speed, double acceleration, double control, double braking)
        {
            driverPower = speed * 3 + acceleration * 3 + control * 2 + braking * 2;   /// From 0 to 100
            return driverPower;
        }
         
        public override string ToString()
        {
            return "Name: " + Name + " ~~~~  Driver power: " + driverPower + "\nTopSpeed:     " + Speed + "  Control: " + Control + "\nAcceleration: " + Acceleration + "  Braking: " + Braking + "\n";
        }

        public static double GenerateDrivers(double EXP)
        { 
            if(EXP < 10){
                DriversStatistics Driver_1 = new DriversStatistics("1 Max Verstappen", 4.34, 1.65, 5.84, 3.23);
                DriversStatistics Driver_2 = new DriversStatistics("2 Daniel Ricciardo", 3.53, 1.25, 2.23, 1.74);
                DriversStatistics Driver_3 = new DriversStatistics("3 Lando Norris", 0.87, 2.29, 1.14, 0.54);
                DriversStatistics Driver_4 = new DriversStatistics("4 Sebastian Vettel", 3.44, 1.61, 2.12, 3.83);
                DriversStatistics Driver_5 = new DriversStatistics("5 Pierre Gasly", 1.45, 1.87, 2.16, 2.56);
                List<DriversStatistics> DriverList = new List<DriversStatistics>();
                DriverList.Add(Driver_1);
                DriverList.Add(Driver_2);
                DriverList.Add(Driver_3);
                DriverList.Add(Driver_4);
                DriverList.Add(Driver_5);

                foreach (DriversStatistics X in DriverList)
                {
                    Console.WriteLine(X.ToString());
                }

                DriversStatistics[] DriversTab = { Driver_1, Driver_2, Driver_3, Driver_4, Driver_5 };
                return ChooseDriver(DriversTab);
            }
            if ((EXP >= 10) && (EXP < 20))
            {
                DriversStatistics Driver_1 = new DriversStatistics("1 Robert Kubica", 4.76, 8.62, 5.61, 7.55);
                DriversStatistics Driver_2 = new DriversStatistics("2 Sobiesław Zasada", 6.56, 3.38, 7.99, 3.26);
                DriversStatistics Driver_3 = new DriversStatistics("3 Krzysztof Hołowczyc", 6.11, 5.41, 6.84, 5.27);
                DriversStatistics Driver_4 = new DriversStatistics("4 Leszek Kuzaj", 3.84, 3.82, 5.97, 3.24);
                DriversStatistics Driver_5 = new DriversStatistics("5 Sebastian Wasiak", 2.74, 6.33, 4.51, 5.88);
                List<DriversStatistics> DriverList = new List<DriversStatistics>();
                DriverList.Add(Driver_1);
                DriverList.Add(Driver_2);
                DriverList.Add(Driver_3);
                DriverList.Add(Driver_4);
                DriverList.Add(Driver_5);

                foreach (DriversStatistics X in DriverList)
                {
                    Console.WriteLine(X.ToString());
                }

                DriversStatistics[] DriversTab = { Driver_1, Driver_2, Driver_3, Driver_4, Driver_5 };
                return ChooseDriver(DriversTab);
            }
            if ((EXP >= 20) && (EXP < 30))
            {
                DriversStatistics Driver_1 = new DriversStatistics("1 Mariusz Pudzianowski", 9.06, 8.73, 8.96, 9.91);
                DriversStatistics Driver_2 = new DriversStatistics("2 Marcin Najman", 6.61, 9.63, 7.57, 8.91);
                DriversStatistics Driver_3 = new DriversStatistics("3 Tomasz Hajto", 5.44, 8.17, 7.61, 7.88);
                DriversStatistics Driver_4 = new DriversStatistics("4 Krzysztof Stanowski", 7.21, 9.12, 4.18, 9.95);
                DriversStatistics Driver_5 = new DriversStatistics("5 Kamil Durczok", 9.61, 7.38, 8.51, 8.95);
                List<DriversStatistics> DriverList = new List<DriversStatistics>();
                DriverList.Add(Driver_1);
                DriverList.Add(Driver_2);
                DriverList.Add(Driver_3);
                DriverList.Add(Driver_4);
                DriverList.Add(Driver_5);

                foreach (DriversStatistics X in DriverList)
                {
                    Console.WriteLine(X.ToString());
                }

                DriversStatistics[] DriversTab = { Driver_1, Driver_2, Driver_3, Driver_4, Driver_5 };
                return ChooseDriver(DriversTab);
            }
            return 0;
        }

        public static double ChooseDriver(DriversStatistics[] D){
            Console.WriteLine("Choose a driver 1-5 and press the number: \nBACK -> Press ENTER");
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
                    Console.Clear(); Menu.StartMenu(); break;
                case 1:
                    return D[0].driverPower;
                case 2:
                    return D[1].driverPower;
                case 3:
                    return D[2].driverPower;
                case 4:
                    return D[3].driverPower;
                case 5:
                    return D[4].driverPower;
                default:
                    Console.WriteLine("WRONG NUMBER !");
                    break;
            }
            return 0;
         }
    }
}
