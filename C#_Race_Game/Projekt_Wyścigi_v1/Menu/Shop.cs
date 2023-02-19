using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Shop 
    {
        static string[] menuItems = { "Auto Parts", "Car Dealership", "Back" };
        static string[] menuItemsParts = { "Engine", "Turbo", "Tires", "Brakes", "Back" };
        static string[] menuItemsCars = { "Usa Cars", "Japan Cars", "Europe Cars", "Back" };

        static int currentPositionMenu = 0;

        public static void StartShop()
        {
            currentPositionMenu = 0;
            Console.Title = "Shop";
            Console.CursorVisible = false;
            while (true)
            {
                MenuMechanics.ShowMenu(currentPositionMenu, menuItems);
                currentPositionMenu = MenuMechanics.SelectingOption(currentPositionMenu, menuItems);
                RunningOptions();
            }
        }

        public static void StartShopItemsParts()
        {
            Console.Title = "Shop - Items Parts";
            Console.CursorVisible = false;
            while (true)
            {
                MenuMechanics.ShowMenu(currentPositionMenu, menuItemsParts);
                currentPositionMenu = MenuMechanics.SelectingOption(currentPositionMenu, menuItemsParts);
                RunningOptionsShopItemsParts();
            }
        }
        public static void StartShopItemsCars()
        {
            Console.Title = "Shop - Items Cars";
            Console.CursorVisible = false;
            while (true)
            {
                MenuMechanics.ShowMenu(currentPositionMenu, menuItemsCars);
                currentPositionMenu = MenuMechanics.SelectingOption(currentPositionMenu, menuItemsCars);
                RunningOptionsShopItemsCars();
            }
        }

        static void RunningOptions()
        {
            switch (currentPositionMenu)
            {
                case 0: Console.Clear(); StartShopItemsParts(); break;
                case 1: Console.Clear(); StartShopItemsCars(); break;
                case 2: Console.Clear(); Menu.StartMenu(); break;
            }
        }

        static void RunningOptionsShopItemsParts()
        {
            switch (currentPositionMenu)
            {
                case 0: Console.Clear(); PlayerStatistics.BuyEngine(); break;
                case 1: Console.Clear(); PlayerStatistics.BuyTurbo(); break;
                case 2: Console.Clear(); PlayerStatistics.BuyTires(); break;
                case 3: Console.Clear(); PlayerStatistics.BuyBrakes(); break;
                case 4: Console.Clear(); StartShop(); break;
            }
        }

        static void RunningOptionsShopItemsCars()
        {
            switch (currentPositionMenu)
            {
                case 0: Console.Clear(); PlayerStatistics.BuyUsaCar(); break;
                case 1: Console.Clear(); PlayerStatistics.BuyJapanCar(); break;
                case 2: Console.Clear(); PlayerStatistics.BuyEuropeCar(); break;
                case 3: Console.Clear(); StartShop(); break;
            }
        }
    }
}