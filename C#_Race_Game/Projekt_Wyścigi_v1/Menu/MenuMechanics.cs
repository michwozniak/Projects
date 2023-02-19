using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public abstract class MenuMechanics
    {
        public static int SelectingOption(int currentPositionMenu, string[] menuItems)
        {
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    currentPositionMenu = (currentPositionMenu > 0) ? currentPositionMenu - 1 : menuItems.Length - 1;
                    ShowMenu(currentPositionMenu, menuItems);
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    currentPositionMenu = (currentPositionMenu + 1) % menuItems.Length;
                    ShowMenu(currentPositionMenu, menuItems);
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    currentPositionMenu = menuItems.Length - 1;
                    break;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
            } while (true);
            return currentPositionMenu;
        }

        public static void ShowMenu(int currentPositionMenu, string[] menuItems)
        {
            Console.Write(Graphic.ShowGraphic());

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == currentPositionMenu)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("  {0,-9}", menuItems[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(menuItems[i]);
                }
            }

            PlayerStatistics.ShowPlayerStatistics();
        }
    }
}
 