using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class WareHouse
    {
        static int EnginePower = 110;
        static int TurboPower = 90;
        static int TiresPower = 40;
        static int BrakesPower = 50;
        static int i = 1;
        public static int Number { get; set; }

        public static Turbo CreateShopTurbo()
        {
            EuropeParts europeParts = new EuropeParts();
            JapanParts japanParts = new JapanParts();
            UsaParts usaParts = new UsaParts();
            List<Turbo> TurboList = new List<Turbo>();
            Turbo[] TurboTab = new Turbo[7];
            

            Random rand = new Random();
            double stats1 = rand.Next(1, TurboPower);
            double stats2 = rand.Next(1, TurboPower);
            int Price = (int)((stats1 * stats2) / 80);
            if(Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TurboList.Add(europeParts.CreateTurbo("europe", Price, stats1, stats2));
            TurboTab[0] = (europeParts.CreateTurbo("europe", Price, stats1, stats2));
            stats1 = rand.Next(1, TurboPower);
            stats2 = rand.Next(1, TurboPower);
            Price = (int)((stats1 * stats2) / 80);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TurboList.Add(europeParts.CreateTurbo("europe", Price, stats1, stats2));
            TurboTab[1] = (europeParts.CreateTurbo("europe", Price, stats1, stats2));
            stats1 = rand.Next(1, TurboPower);
            stats2 = rand.Next(1, TurboPower);
            Price = (int)((stats1 * stats2) / 60);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TurboList.Add(japanParts.CreateTurbo("japan", Price, stats1, stats2));
            TurboTab[2] = (europeParts.CreateTurbo("japan", Price, stats1, stats2));
            stats1 = rand.Next(1, TurboPower);
            stats2 = rand.Next(1, TurboPower);
            Price = (int)((stats1 * stats2) / 60);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TurboList.Add(japanParts.CreateTurbo("japan", Price, stats1, stats2));
            TurboTab[3] = (europeParts.CreateTurbo("japan", Price, stats1, stats2));
            stats1 = rand.Next(1, TurboPower);
            stats2 = rand.Next(1, TurboPower);
            Price = (int)((stats1 * stats2) / 70);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TurboList.Add(usaParts.CreateTurbo("usa", Price, stats1, stats2));
            TurboTab[4] = (europeParts.CreateTurbo("usa", Price, stats1, stats2));
            stats1 = rand.Next(1, TurboPower);
            stats2 = rand.Next(1, TurboPower);
            Price = (int)((stats1 * stats2) / 70);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TurboList.Add(usaParts.CreateTurbo("usa", Price, stats1, stats2));
            TurboTab[5] = (europeParts.CreateTurbo("usa", Price, stats1, stats2));

            i = 1;
            foreach (Turbo X in TurboList)
            {
                Console.WriteLine("Number:" + i + ">" + X.ToString());
                i++;
            }
            TurboTab[6] = (europeParts.CreateTurbo("", 0, 0, 0));
            return ChooseTurbo(TurboTab); 
        }

        public static Turbo ChooseTurbo(Turbo[] D)
        {
            Console.WriteLine("Choose Your new Turbo upgrade part 1-6 and press the number: \nBACK -> Press ENTER");
            string enter = Console.ReadLine();
            if (enter == "") { Number = 0; }
            else
            {
                Number = int.Parse(enter);
            }

            while (Number < 0 || Number > 6)
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
                case 6:
                    return D[5];
                default:
                    Console.WriteLine("WRONG NUMBER !");
                    break;
            }
            return D[6];
        }

        public static Tires CreateShopTires()
        {
            EuropeParts europeParts = new EuropeParts();
            JapanParts japanParts = new JapanParts();
            UsaParts usaParts = new UsaParts();
            List<Tires> TiresList = new List<Tires>();
            Tires[] TiresTab = new Tires[7];

            Random rand = new Random();
            double stats1 = rand.Next(1, TiresPower);
            double stats2 = rand.Next(1, TiresPower);
            double Tirelive = rand.Next(30, 100);        // Tire Life, between 30 - 100
            int Price = (int)(((stats1/2) * (stats2/2) * Tirelive) / 120);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TiresList.Add(europeParts.CreateTires("europe", Price, stats1, stats2, Tirelive));
            TiresTab[0] = (europeParts.CreateTires("europe", Price, stats1, stats2, Tirelive));
            stats1 = rand.Next(1, TiresPower);
            stats2 = rand.Next(1, TiresPower);
            Tirelive = rand.Next(30, 100);
            Price = (int)(((stats1 / 2) * (stats2 / 2) * Tirelive) / 120);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TiresList.Add(europeParts.CreateTires("europe", Price, stats1, stats2, Tirelive));
            TiresTab[1] = (europeParts.CreateTires("europe", Price, stats1, stats2, Tirelive));
            stats1 = rand.Next(1, TiresPower);
            stats2 = rand.Next(1, TiresPower);
            Tirelive = rand.Next(30, 100);
            Price = (int)(((stats1 / 2) * (stats2 / 2) * Tirelive) / 120);
            if(Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TiresList.Add(japanParts.CreateTires("japan", Price, stats1, stats2, Tirelive));
            TiresTab[2] = (japanParts.CreateTires("japan", Price, stats1, stats2, Tirelive));
            stats1 = rand.Next(1, TiresPower);
            stats2 = rand.Next(1, TiresPower);
            Tirelive = rand.Next(30, 100);
            Price = (int)(((stats1 / 2) * (stats2 / 2) * Tirelive) / 120);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TiresList.Add(japanParts.CreateTires("japan", Price, stats1, stats2, Tirelive));
            TiresTab[3] = (japanParts.CreateTires("japan", Price, stats1, stats2, Tirelive));
            stats1 = rand.Next(1, TiresPower);
            stats2 = rand.Next(1, TiresPower);
            Tirelive = rand.Next(30, 100);
            Price = (int)(((stats1 / 2) * (stats2 / 2) * Tirelive) / 120);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TiresList.Add(usaParts.CreateTires("usa", Price, stats1, stats2, Tirelive));
            TiresTab[4] = (usaParts.CreateTires("usa", Price, stats1, stats2, Tirelive));
            stats1 = rand.Next(1, TiresPower);
            stats2 = rand.Next(1, TiresPower);
            Tirelive = rand.Next(30, 100);
            Price = (int)(((stats1 / 2) * (stats2 / 2) * Tirelive) / 120);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            TiresList.Add(usaParts.CreateTires("usa", Price, stats1, stats2, Tirelive));
            TiresTab[5] = (usaParts.CreateTires("usa", Price, stats1, stats2, Tirelive));

            i = 1;
            foreach (Tires X in TiresList)
            {
                Console.WriteLine("Number:" + i + ">" + X.ToString());
                i++;
            }
            TiresTab[6] = (usaParts.CreateTires("", 0, 0, 0, 0));
            return ChooseTires(TiresTab);
        }

        public static Tires ChooseTires(Tires[] D)
        {
            Console.WriteLine("Choose Your new Tires upgrade part 1-6 and press the number: \nBACK -> Press ENTER");
            string enter = Console.ReadLine();
            if (enter == "") { Number = 0; }
            else
            {
                Number = int.Parse(enter);
            }

            while (Number < 0 || Number > 6)
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
                case 6:
                    return D[5];
                default:
                    Console.WriteLine("WRONG NUMBER !");
                    break;
            }
            return D[6];
        }

        public static Brakes CreateShopBrakes()
        {
            EuropeParts europeParts = new EuropeParts();
            JapanParts japanParts = new JapanParts();
            UsaParts usaParts = new UsaParts();
            List<Brakes> BrakesList = new List<Brakes>();
            Brakes[] BrakesTab = new Brakes[7];

            Random rand = new Random();
            double stats1 = rand.Next(1, BrakesPower);
            double stats2 = rand.Next(1, BrakesPower);
            int Price = (int)((stats1 * stats2) / 60);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            BrakesList.Add(europeParts.CreateBrakes("europe", Price, stats1, stats2));
            BrakesTab[0] = (europeParts.CreateBrakes("europe", Price, stats1, stats2));
            stats1 = rand.Next(1, BrakesPower);
            stats2 = rand.Next(1, BrakesPower);
            Price = (int)((stats1 * stats2) / 60);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            BrakesList.Add(europeParts.CreateBrakes("europe", Price, stats1, stats2));
            BrakesTab[1] = (europeParts.CreateBrakes("europe", Price, stats1, stats2));
            stats1 = rand.Next(1, BrakesPower);
            stats2 = rand.Next(1, BrakesPower);
            Price = (int)((stats1 * stats2) / 50);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            BrakesList.Add(japanParts.CreateBrakes("japan", Price, stats1, stats2));
            BrakesTab[2] = (europeParts.CreateBrakes("japan", Price, stats1, stats2));
            stats1 = rand.Next(1, BrakesPower);
            stats2 = rand.Next(1, BrakesPower);
            Price = (int)((stats1 * stats2) / 50);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            BrakesList.Add(japanParts.CreateBrakes("japan", Price, stats1, stats2));
            BrakesTab[3] = (europeParts.CreateBrakes("japan", Price, stats1, stats2));
            stats1 = rand.Next(1, BrakesPower);
            stats2 = rand.Next(1, BrakesPower);
            Price = (int)((stats1 * stats2) / 70);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            BrakesList.Add(usaParts.CreateBrakes("usa", Price, stats1, stats2));
            BrakesTab[4] = (europeParts.CreateBrakes("usa", Price, stats1, stats2));
            stats1 = rand.Next(1, BrakesPower);
            stats2 = rand.Next(1, BrakesPower);
            Price = (int)((stats1 * stats2) / 70);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            BrakesList.Add(usaParts.CreateBrakes("usa", Price, stats1, stats2));
            BrakesTab[5] = (europeParts.CreateBrakes("usa", Price, stats1, stats2));

            int i = 1;
            foreach (Brakes X in BrakesList)
            {
                Console.WriteLine("Number:" + i + ">" + X.ToString());
                i++;
            }
            BrakesTab[6] = (europeParts.CreateBrakes("", 0, 0, 0));
            return ChooseBrakes(BrakesTab);
        }

        public static Brakes ChooseBrakes(Brakes[] D)
        {
            Console.WriteLine("Choose Your new Brakes upgrade part 1-6 and press the number: \nBACK -> Press ENTER");
            string enter = Console.ReadLine();
            if (enter == "") { Number = 0; }
            else
            {
                Number = int.Parse(enter);
            }

            while (Number < 0 || Number > 6)
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
                case 6:
                    return D[5];
                default:
                    Console.WriteLine("WRONG NUMBER !");
                    break;
            }
            return D[6];
        }

        public static Engine CreateShopEngine()
        {
            EuropeParts europeParts = new EuropeParts();
            JapanParts japanParts = new JapanParts();
            UsaParts usaParts = new UsaParts();
            List<Engine> EngineList = new List<Engine>();
            Engine[] EngineTab = new Engine[7];

            Random rand = new Random();
            double stats1 = rand.Next(0, EnginePower);
            double stats2 = rand.Next(0, EnginePower);
            int Price = (int)((stats1 * stats2) / 20);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            EngineList.Add(europeParts.CreateEngine("europe", Price, stats1, stats2));
            EngineTab[0] = (europeParts.CreateEngine("europe", Price, stats1, stats2));
            stats1 = rand.Next(5, EnginePower);
            stats2 = rand.Next(5, EnginePower);
            Price = (int)((stats1 * stats2) / 20);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            EngineList.Add(europeParts.CreateEngine("europe", Price, stats1, stats2));
            EngineTab[1] = (europeParts.CreateEngine("europe", Price, stats1, stats2));
            stats1 = rand.Next(5, EnginePower);
            stats2 = rand.Next(5, EnginePower);
            Price = (int)((stats1 * stats2) / 25);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            EngineList.Add(japanParts.CreateEngine("japan", Price, stats1, stats2));
            EngineTab[2] = (europeParts.CreateEngine("japan", Price, stats1, stats2));
            stats1 = rand.Next(5, EnginePower);
            stats2 = rand.Next(5, EnginePower);
            Price = (int)((stats1 * stats2) / 25);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            EngineList.Add(japanParts.CreateEngine("japan", Price, stats1, stats2));
            EngineTab[3] = (europeParts.CreateEngine("japan", Price, stats1, stats2));
            stats1 = rand.Next(5, EnginePower);
            stats2 = rand.Next(5, EnginePower);
            Price = (int)((stats1 * stats2) / 30);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            EngineList.Add(usaParts.CreateEngine("usa", Price, stats1, stats2));
            EngineTab[4] = (europeParts.CreateEngine("usa", Price, stats1, stats2));
            stats1 = rand.Next(5, EnginePower);
            stats2 = rand.Next(5, EnginePower);
            Price = (int)((stats1 * stats2) / 30);
            if (Price == 0)
            {
                Price = 1;
            }
            stats1 /= 100;
            stats2 /= 100;
            EngineList.Add(usaParts.CreateEngine("usa", Price, stats1, stats2));
            EngineTab[5] = (europeParts.CreateEngine("usa", Price, stats1, stats2));
            

            int i = 1;
            foreach (Engine X in EngineList)
            {
                Console.WriteLine("Number:" + i + ">" + X.ToString());
                i++;
            }

            EngineTab[6] = (europeParts.CreateEngine("", 0, 0, 0));
            return ChooseEngine(EngineTab);
        }

        public static Engine ChooseEngine(Engine[] D)
        {
            Console.WriteLine("Choose Your new Engine upgrade part 1-6 and press the number: \nBACK -> Press ENTER");
            string enter = Console.ReadLine();
            if (enter == "") { Number = 0; }
            else
            {
                Number = int.Parse(enter);
            }

            while (Number < 0 || Number > 6)
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
                case 6:
                    return D[5];
                default:
                    Console.WriteLine("WRONG NUMBER !");
                    break;
            }
            return D[6];
        }
    }
}
