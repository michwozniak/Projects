using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public abstract class StartRace : Statistics
    {
        public static double OponentPower, playerPower, tireLife;

        public static void StartRaceOption()
        {
            playerPower = PlayerStatistics.SetPlayerPower();  // Aktualizacja na bierząco mocy gracza na podstawie jego statystyk

            if (playerPower == 0)
            {
                Shop.StartShopItemsCars();  // Kupno samochodu na początek gry
            }

            tireLife = PlayerStatistics.SetNewLifeTires();   // Ustawia aktualną wartość opon przed wyścigiem
            tireLife = PlayerStatistics.SetLifeTires(tireLife);  // Ustawia nową wartość opon po wyścigu, w zależności od incydentu w wyścigu ustawia nową wartość

            OponentPower = PlayerStatistics.SetOponent();     // Oponent power przyjmuje statystyki gracza którego wybierzemy numerkiem
            bool Event = true;  // Zerowanie flagi wystąpienia incydentu 

            if (tireLife < 0 && Event)
            {
                Event = false;
                Graphic.ShowAnimationTires();  // Animacja Incydentu Opony
                PlayerStatistics.IncreaseExp(OponentPower);
                PlayerStatistics.GainMoney((int)(OponentPower * 2));
                Console.WriteLine("\n            +--------------------------+");
                Console.WriteLine("            |  Gain money: " + (int)(OponentPower * 2) + "          |");
                Console.WriteLine("            |  Fuel costs: " + (int)((Fuel.FuelCosts() * playerPower) / 4) + "          |");
                Console.WriteLine("            |  Tire Life: " + 0 + "            |");
                Console.WriteLine("            |  Puncture of the tire !  |");
                Console.WriteLine("            +--------------------------+");
                PlayerStatistics.LossMoney((int)((Fuel.FuelCosts() * playerPower) / 4));
                Console.ReadLine();
                Console.Clear();
                PlayerStatistics.IncreaseNumberOfRaces();
                PlayerStatistics.BuyTires();
                tireLife = PlayerStatistics.SetNewLifeTires();
            }
            if (OponentPower <= playerPower && PlayerStatistics.EngineProblem() && Event)
            {
                Event = false;
                Graphic.ShowAnimationEngine();  // Animacja Incydentu Silnik
                PlayerStatistics.IncreaseExp(OponentPower);
                Console.WriteLine("\n            +-----------------------+");
                Console.WriteLine("            |  Gain money: 0        |");    
                Console.WriteLine("            |  Fuel costs: 0        |");    
                Console.WriteLine("            |  Engine Explosion !   |");
                Console.WriteLine("            +-----------------------+");
                Console.ReadLine();
                Console.Clear();
                PlayerStatistics.IncreaseNumberOfRaces();         
                PlayerStatistics.BuyEngine();
            }
            if (OponentPower <= playerPower && PlayerStatistics.BrakesProblem() && Event)
            {
                Event = false;
                Graphic.ShowAnimationLoss();  // Animacja Incydentu Hamulce
                PlayerStatistics.IncreaseExp(OponentPower);
                PlayerStatistics.GainMoney((int)(OponentPower));
                Console.WriteLine("\n            +-----------------------+");
                Console.WriteLine("            |  Gain money: " + (int)(OponentPower) + "       |");                
                Console.WriteLine("            |  Fuel costs: " + (int)((Fuel.FuelCosts() * playerPower) / 4) + "       |");
                Console.WriteLine("            |  Tire Life: " + tireLife + "        |");               
                Console.WriteLine("            |  Brakes Overheated !  |");
                Console.WriteLine("            +-----------------------+");
                PlayerStatistics.LossMoney((int)((Fuel.FuelCosts() * playerPower) / 4));
                PlayerStatistics.UpdatetireLife(tireLife);
                Console.ReadLine();
                Console.Clear();
                PlayerStatistics.IncreaseNumberOfRaces();     
                PlayerStatistics.BuyBrakes();
            }
            if (OponentPower <= playerPower && PlayerStatistics.TurboBoost() && Event)
            {
                Event = false;
                Graphic.ShowAnimationTurbo();  // Animacja Incydentu Turbo
                PlayerStatistics.IncreaseExp(OponentPower * 1.5);
                PlayerStatistics.GainMoney((int)(OponentPower * 2.5));
                Console.WriteLine("\n            +------------------+");
                Console.WriteLine("            |  Gain money: " + (int)(OponentPower * 2.5) + "  |");
                Console.WriteLine("            |  Fuel costs: " + (int)((Fuel.FuelCosts() * playerPower) / 4) + "  |");
                Console.WriteLine("            |  Tire Life: " + tireLife + "   |");
                Console.WriteLine("            |  Turbo BOOST !   |");
                Console.WriteLine("            +------------------+");
                PlayerStatistics.LossMoney((int)((Fuel.FuelCosts() * playerPower) / 4));
                PlayerStatistics.UpdatetireLife(tireLife);
                Console.ReadLine();
                Console.Clear();
                PlayerStatistics.IncreaseNumberOfRaces();
                PlayerStatistics.BuyTurbo();
            }
            if (OponentPower <= playerPower && Event) {
                Event = false;
                Graphic.ShowAnimationWin();
                PlayerStatistics.IncreaseExp(OponentPower*1.2);
                PlayerStatistics.IncreaseLVL();
                PlayerStatistics.GainMoney((int)(OponentPower * 9));
                PlayerStatistics.IncreaseNumberOfRaces();
                Console.WriteLine("\n        +------------------+");
                Console.WriteLine("        |  Gain money: " + (int)(OponentPower * 9) + " |");                   
                Console.WriteLine("        |  Fuel costs: " + (int)((Fuel.FuelCosts() * playerPower) / 4) + "  |");
                Console.WriteLine("        |  Tire Life: " + tireLife + "   |");
                Console.WriteLine("        +------------------+");
                PlayerStatistics.LossMoney((int)((Fuel.FuelCosts() * playerPower) / 4));
                PlayerStatistics.UpdatetireLife(tireLife);
            }
            else if(OponentPower > playerPower && Event)
            {
                Graphic.ShowAnimationLoss();
                PlayerStatistics.IncreaseExp(OponentPower); 
                PlayerStatistics.GainMoney((int)(OponentPower * 2));
                PlayerStatistics.IncreaseNumberOfRaces();
                Console.WriteLine("\n            +------------------+");
                Console.WriteLine("            |  Gain money: " + (int)(OponentPower * 2) + "  |");                  
                Console.WriteLine("            |  Fuel costs: " + (int)((Fuel.FuelCosts() * playerPower) / 4) + "  |");
                Console.WriteLine("            |  Tire Life: " + tireLife + "   |");
                Console.WriteLine("            +------------------+");
                PlayerStatistics.LossMoney((int)((Fuel.FuelCosts() * playerPower) / 6));
                PlayerStatistics.UpdatetireLife(tireLife);
            }
            Console.ReadKey();
        }
    }
}