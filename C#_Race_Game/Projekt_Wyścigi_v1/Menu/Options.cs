using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Options 
    {
        static string[] menuItems = { "Tutorial", "Animations TEST", "Curiosities", "Back" };
        static string[] menuAnimations = { "Win", "Loss", "Engine incident", "Tires incident", "Turbo incident", "Back" };
        static int currentPositionMenu = 0;

        public static void StartOptions()
        {
            currentPositionMenu = 0;
            Console.Title = "Menu";
            Console.CursorVisible = false;
            while (true)
            {
                MenuMechanics.ShowMenu(currentPositionMenu, menuItems);
                currentPositionMenu = MenuMechanics.SelectingOption(currentPositionMenu, menuItems);
                RunningOptions();
            }
        }

        public static void StartAnimations()
        {
            currentPositionMenu = 0;
            Console.Title = "Animations";
            Console.CursorVisible = false;
            while (true)
            {
                MenuMechanics.ShowMenu(currentPositionMenu, menuAnimations);
                currentPositionMenu = MenuMechanics.SelectingOption(currentPositionMenu, menuAnimations);
                RunningAnimations();
            }
        }

        static void RunningAnimations()
        {
            switch (currentPositionMenu)
            {
                case 0: Console.Clear(); Graphic.ShowAnimationWin();  break;
                case 1: Console.Clear(); Graphic.ShowAnimationLoss(); break;
                case 2: Console.Clear(); Graphic.ShowAnimationEngine(); break;
                case 3: Console.Clear(); Graphic.ShowAnimationTires(); break;
                case 4: Console.Clear(); Graphic.ShowAnimationTurbo(); break;
                case 5: Console.Clear(); Menu.StartMenu(); break;
            }
        }

        static void RunningOptions()
        {
            switch (currentPositionMenu)
            {
                case 0: Console.Clear(); Tutorial.ShowTutorial();  break;
                case 1: Console.Clear(); StartAnimations(); break;
                case 2: Console.Clear(); Graphic.Curiosities(); break;
                case 3: Console.Clear(); Menu.StartMenu(); break;
            }
        }
    }
}
