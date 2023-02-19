using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class PlayerStatistics : Statistics
    {
        double playerPower;
        double Tirelife;
        string Tirename, Brakesname, Enginename, Turboname;

        public PlayerStatistics(string CarName, double speed, double acceleration, double control, double braking, int exp, int lvl, int NumberOfRaces, int money)
        {
            carName = CarName;
            Speed = speed;
            Acceleration = acceleration;
            Control = control;
            Braking = braking;
            Exp = exp;
            Lvl = lvl;
            numberOfRaces = NumberOfRaces;
            Money = money;
            playerPower = PlayerPower(Speed, Acceleration, Control, Braking);

        }
        private static PlayerStatistics Player = new PlayerStatistics("SCRAP", 0, 0, 0, 0, 0, 0, 0, 1230);  // Player initiation

        public double PlayerPower(double Speed, double Acceleration, double Control, double Braking)
        {
            playerPower = Speed * 3 + Acceleration * 3 + Control * 2 + Braking * 2;  /// From 0 to 100
            return playerPower;
        }     

        ////////////////////////////////////////////////       POWER
        public static double SetPlayerPower()
        {
            Player.playerPower = Player.Speed * 3 + Player.Acceleration * 3 + Player.Control * 2 + Player.Braking * 2;
            return Player.playerPower;
        }
        public static void PlayerPowerUpdate()
        {
            Player.playerPower = Player.Speed * 3 + Player.Acceleration * 3 + Player.Control * 2 + Player.Braking * 2;
        }

        ////////////////////////////////////////////////       INCREASE

        public static void IncreaseNumberOfRaces()
        {
            Player.numberOfRaces++;
        }
        public static void IncreaseExp(double oponentPower)
        {
            Player.Exp += (int)(oponentPower * 3);
        }
        public static void IncreaseLVL()
        {
            Player.Lvl++;
        }
        public static double SetOponent()
        {
            return DriversStatistics.GenerateDrivers(Player.Lvl);
        }
        public static void GainMoney(int Prize)
        {
            Player.Money += Prize;
        }
        public static void LossMoney(int Prize)
        {
            Player.Money -= Prize;
            if(Player.Money < 0)
            {
                Console.WriteLine("\nATTENTION !! You are going on credit!\n");
                System.Threading.Thread.Sleep(700);
                Console.Clear();
            }
        }

        ////////////////////////////////////////////////       SHOW STATISTICS

        public static void ShowPlayerStatistics()
        {
            Console.WriteLine("\n\n\nCurrent Player Stats >      POWER: " + Player.playerPower +"\n");
            Console.WriteLine("Car Model:  " + Player.carName + "   |   Tire Life: "+ Player.Tirelife);
            Console.WriteLine("Top Speed: " + Player.Speed + "  Control: " + Player.Control + "\nAcceleration: " + Player.Acceleration + "  Braking: " + Player.Braking);
            Console.WriteLine("Money: " + Player.Money + "  EXP: " + Player.Exp + "  LVL: " + Player.Lvl + "  Total number of races: " + Player.numberOfRaces);
        }

        ////////////////////////////////////////////////       CARS

        public static void BuyUsaCar()
        {
            UsaCars Car1 = UsaCars.GenerateUsaCars();

            if(Car1.Name == ""){}
            else if (Car1.Price <= Player.Money)
            {
                LossMoney(Car1.Price);
                if (Player.Speed < 10) { Player.Speed = Car1.Speed; }
                if (Player.Control < 10) { Player.Control = Car1.Control; }
                if (Player.Braking < 10) { Player.Braking = Car1.Braking; }               
                Player.carName = Car1.Name;
                Player.Tirelife = 50;
                Player.Lvl = 0;
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }
        public static void BuyJapanCar()
        {
            JapanCars Car2 = JapanCars.GenerateJapanCars();

            if (Car2.Name == "") { }
            else if (Car2.Price <= Player.Money)
            {
                LossMoney(Car2.Price);
                Player.Speed = Car2.Speed;
                Player.Acceleration = Car2.Acceleration;
                Player.Control = Car2.Control;
                Player.Braking = Car2.Braking;
                Player.carName = Car2.Name;
                Player.Tirelife = 60;
                Player.Lvl = 0;
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }
        public static void BuyEuropeCar()
        {
            EuropeCars Car3 = EuropeCars.GenerateEuropeCars();

            if (Car3.Name == "") { }
            else if (Car3.Price <= Player.Money)
            {
                LossMoney(Car3.Price);
                Player.Speed = Car3.Speed;
                Player.Acceleration = Car3.Acceleration;
                Player.Control = Car3.Control;
                Player.Braking = Car3.Braking;
                Player.carName = Car3.Name;
                Player.Tirelife = 55;
                Player.Lvl = 0;
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }


        ////////////////////////////////////////////////       BUY PARTS

        public static void BuyTurbo()
        {
            Turbo turbo = WareHouse.CreateShopTurbo();

            if (turbo.Price == 0) { }
            else if (turbo.Price <= Player.Money)
            {
                LossMoney(turbo.Price);
                if (Player.Speed < 10) { Player.Speed += turbo.Speed; }
                if (Player.Acceleration < 10) { Player.Acceleration += turbo.Acceleration; }
                Player.Turboname = turbo.Name;

                if((Player.Turboname == "europe") && ((Player.carName == ("Skoda Superb IV" )) || (Player.carName == ("Volkswagen Golf 8 R")) 
                    || (Player.carName == ("BMW M3 Competition")) || (Player.carName == ("Mercedes G Klasa")) || (Player.carName == ("Mercedes A45 AMG"))))
                {
                    Player.Speed += 0.1;
                }
                if ((Player.Turboname == "usa") && ((Player.carName == ("Ford Mustang")) || (Player.carName == ("Chevrolet Corvette"))
                    || (Player.carName == ("Doge RAM")) || (Player.carName == ("Jeep Wrangler")) || (Player.carName == ("Tesla Model S"))))
                {
                    Player.Speed += 0.1;                  
                }
                if ((Player.Turboname == "japan") && ((Player.carName == ("Nissan Skyline R34 GT-R")) || (Player.carName == ("Honda Civic X"))
                    || (Player.carName == ("Mazda RX-7")) || (Player.carName == ("Toyota Supra")) || (Player.carName == ("Subaru Impreza WRX STI"))))
                {
                    Player.Speed += 0.1;
                }
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }
        public static void BuyEngine()
        {
            Engine engine = WareHouse.CreateShopEngine();

            if (engine.Price == 0) { }
            else if (engine.Price <= Player.Money)
            {
                LossMoney(engine.Price);
                if (Player.Speed < 10) { Player.Speed += engine.Speed; }
                if (Player.Acceleration < 10) { Player.Acceleration += engine.Acceleration; }
                Player.Enginename = engine.Name;
                if ((Player.Enginename == "europe") && ((Player.carName == ("Skoda Superb IV")) || (Player.carName == ("Volkswagen Golf 8 R"))
                    || (Player.carName == ("BMW M3 Competition")) || (Player.carName == ("Mercedes G Klasa")) || (Player.carName == ("Mercedes A45 AMG"))))
                {
                    Player.Speed += 0.1;
                    Player.Acceleration += 0.1;
                }
                if ((Player.Enginename == "usa") && ((Player.carName == ("Ford Mustang")) || (Player.carName == ("Chevrolet Corvette"))
                    || (Player.carName == ("Doge RAM")) || (Player.carName == ("Jeep Wrangler")) || (Player.carName == ("Tesla Model S"))))
                {
                    Player.Speed += 0.1;
                    Player.Acceleration += 0.1;
                }
                if ((Player.Enginename == "japan") && ((Player.carName == ("Nissan Skyline R34 GT-R")) || (Player.carName == ("Honda Civic X"))
                    || (Player.carName == ("Mazda RX-7")) || (Player.carName == ("Toyota Supra")) || (Player.carName == ("Subaru Impreza WRX STI"))))
                {
                    Player.Speed += 0.1;
                    Player.Acceleration += 0.1;
                }
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }
        public static void BuyTires()
        {
            Tires tires = WareHouse.CreateShopTires();

            if (tires.Price == 0) { }
            else if (tires.Price <= Player.Money)
            {
                LossMoney(tires.Price);
                if (Player.Control < 10) { Player.Control += tires.Control; }
                if (Player.Acceleration < 10) { Player.Acceleration += tires.Acceleration; }

                Player.Tirelife = tires.TireLife;
                Player.Tirename = tires.Name;
                if ((Player.Tirename == "europe") && ((Player.carName == ("Skoda Superb IV")) || (Player.carName == ("Volkswagen Golf 8 R"))
                    || (Player.carName == ("BMW M3 Competition")) || (Player.carName == ("Mercedes G Klasa")) || (Player.carName == ("Mercedes A45 AMG"))))
                {
                    Player.Acceleration += 0.1;
                }
                if ((Player.Tirename == "usa") && ((Player.carName == ("Ford Mustang")) || (Player.carName == ("Chevrolet Corvette"))
                    || (Player.carName == ("Doge RAM")) || (Player.carName == ("Jeep Wrangler")) || (Player.carName == ("Tesla Model S"))))
                {
                    Player.Acceleration += 0.1;
                }
                if ((Player.Tirename == "japan") && ((Player.carName == ("Nissan Skyline R34 GT-R")) || (Player.carName == ("Honda Civic X"))
                    || (Player.carName == ("Mazda RX-7")) || (Player.carName == ("Toyota Supra")) || (Player.carName == ("Subaru Impreza WRX STI"))))
                {
                    Player.Acceleration += 0.1;
                }
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }
        public static void BuyBrakes()
        {
            Brakes brakes = WareHouse.CreateShopBrakes();

            if (brakes.Price == 0) { }
            else if (brakes.Price <= Player.Money)
            {
                LossMoney(brakes.Price);
                if (Player.Control < 10) { Player.Control += brakes.Control; }
                if (Player.Braking < 10) { Player.Braking += brakes.Braking; }

                Player.Brakesname = brakes.Name;
                if ((Player.Brakesname == "europe") && ((Player.carName == ("Skoda Superb IV")) || (Player.carName == ("Volkswagen Golf 8 R"))
                    || (Player.carName == ("BMW M3 Competition")) || (Player.carName == ("Mercedes G Klasa")) || (Player.carName == ("Mercedes A45 AMG"))))
                {
                    Player.Control += 0.1;       
                }
                if ((Player.Brakesname == "usa") && ((Player.carName == ("Ford Mustang")) || (Player.carName == ("Chevrolet Corvette"))
                    || (Player.carName == ("Doge RAM")) || (Player.carName == ("Jeep Wrangler")) || (Player.carName == ("Tesla Model S"))))
                {
                    Player.Control += 0.1;
                }
                if ((Player.Brakesname == "japan") && ((Player.carName == ("Nissan Skyline R34 GT-R")) || (Player.carName == ("Honda Civic X"))
                    || (Player.carName == ("Mazda RX-7")) || (Player.carName == ("Toyota Supra")) || (Player.carName == ("Subaru Impreza WRX STI"))))
                {
                    Player.Control += 0.1;
                }
                SetPlayerPower();
            }
            else
            {
                Console.WriteLine("\n    Not enough money ! \n     ENTER to return");
                Console.ReadLine();
            }
        }

        ////////////////////////////////////////////////        INCIDENTS

        public static bool EngineProblem()
        {
            if (Player.Enginename == "usa")
            {
                return UsaEngine.EngineProblem();
            }
            else if (Player.Enginename == "europe")
            {
                return EuropeEngine.EngineProblem();
            }
            else if (Player.Enginename == "japan")
            {
                return JapanEngine.EngineProblem();
            }
            else
            {
                return Engine.EngineProblem();
            }
        }
        public static bool BrakesProblem()
        {
            if (Player.Brakesname == "usa")
            {
                return UsaBrakes.BrakesProblem();
            }
            else if (Player.Enginename == "europe")
            {
                return EuropeBrakes.BrakesProblem();
            }
            else if (Player.Enginename == "japan")
            {
                return JapanBrakes.BrakesProblem();
            }
            else
            {
                return Brakes.BrakesProblem();
            }
        }
        public static bool TurboBoost()
        {
            if (Player.Turboname == "usa")
            {
                return UsaTurbo.TurboBoost();
            }
            else if (Player.Turboname == "europe")
            {
                return EuropeTurbo.TurboBoost();
            }
            else if (Player.Turboname == "japan")
            {
                return JapanTurbo.TurboBoost();
            }
            else
            {
                return Turbo.TurboBoost();
            }
        }

        ////////////////////////////////////////////////        TIRES FUNCTIONS

        public static double SetLifeTires(double tireLife)
        {
            if (Player.Tirename == "usa")
            {
                tireLife = UsaTires.FlatTire(tireLife);
            }
            else if (Player.Tirename == "europe")
            {
                tireLife = EuropeTires.FlatTire(tireLife);
            }
            else if (Player.Tirename == "japan")
            {
                tireLife = JapanTires.FlatTire(tireLife);
            }
            else 
            {
                tireLife = Tires.FlatTire(tireLife);
            }
            return tireLife;
        }
        public static double SetNewLifeTires()
        {
            return Player.Tirelife;
        }
        public static void UpdatetireLife(double TireLife)
        {
            Player.Tirelife = TireLife;
        }
    }
}
