using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Menu 
    {
        static string[] menuItems = { "Start Game", "Options", "Shop", "Exit" };
        static int currentPositionMenu = 0;

        public static void StartMenu()
        {
            currentPositionMenu = 0;
            Console.Title = "Menu";
            Console.CursorVisible = false;
            while (true)
            {
                MenuMechanics.ShowMenu(currentPositionMenu, menuItems);
                currentPositionMenu = MenuMechanics.SelectingOption(currentPositionMenu, menuItems);
                RunningMenu();
            }
        }

        static void RunningMenu()
        {
            switch (currentPositionMenu)
            {
                case 0: Console.Clear(); StartRace.StartRaceOption(); break;
                case 1: Console.Clear(); Options.StartOptions(); break;
                case 2: Console.Clear(); Shop.StartShop(); break;
                case 3: Environment.Exit(0); break;
            }
        }

        static void opcjaWBudowie()
        {
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Opcja w budowie\n  menu");
            Console.ReadKey();
        }
    }
}
