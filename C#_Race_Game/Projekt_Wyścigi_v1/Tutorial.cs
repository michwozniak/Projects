using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Tutorial
    {
        public static void ShowTutorial()
        {
            string Page1 = @"
Hello ! You just graduated from the humanities school and You can't find a job.
You got a gift of 50 coins from your grandma.
You've moved to a new city to start over,.
You buy a 20$ scratch card for the received money, AND WIN 1200 COINS !
You decide to fulfill your childhood dream and become a racing driver.

Page 1/7       EXIT -> NR 0
";
            string Page2 = @"
You come to a new city with your scrap car.
First, you need to buy a new car.
You can't afford much, but that will change over time.
You have various car models from Japan, Europe and the USA at your disposal.
Each car has different starting statistics.

Page 2/7       EXIT -> NR 0
";
            string Page3 = @"
Now you can start race !
At first You can choose from 5 opponents of different difficulty levels.
Depending on the opponent's power and the course of the race, you gain EXP
Your payout will increase with the level of your opponents.
For winning the race you earn much more coins than for the lost race.


Page 3/7       EXIT -> NR 0
";
            string Page4 = @"
Remember that after each race you need to pay for refuel the vehicle, depending on car power.
As you increase the number of winning races, you can get better and better opponents
If your car's power is greater than your opponent's power, you have a chance to win,
But it does not mean that you will win for 100% !
You may come across surprises that you will learn about on the following pages of this tutorial.

Page 4/7       EXIT -> NR 0
";
            string Page5 = @"
You can upgrade 4 elements in your vehicle:

Engine - affects the maximum speed and acceleration of the car. 
         There is a different chance, depending on the country of origin,
         that the engine will not withstand the load during take-off and will explode!
         You won't get paid for the race, but you won't have to pay for fuel either.
         After that you have to go to the store to buy a new engine.

Turbo - affects also the maximum speed and acceleration of the car. 
        There is a small chance, depending on the country of origin,
        that you will receive a full nitro cylinder from your friend, 
        just right before the start of the race !  
        This will leave your opponent far behind, crossing the finish line.
        You get a double reward ! 

Page 5/7       EXIT -> NR 0
";
            string Page6 = @"
You can upgrade 4 elements in your vehicle:

Tires - affects the control over the car, and his acceleration. 
        Tires wear out after each race, check the tread level regular,
        if you let to drop it to zero, one of the tires will get punctured!
        You will have to buy a new set of tires in the store.

Brakes - affects the control over the car, and his braking ability. 
         There is a different chance, depending on the country of origin,
         that during the race, the brakes will overheat !
         It results in a lost race, and You will have to buy a new brakes.

Page 6/7       EXIT -> NR 0
";
            string Page7 = @"
Individual stats have a different degree of influence on Player POWER:
Speed = 30% / Acceleration = 30% / Control = 20% / Braking = 20%

If you choose car parts corresponding to the country of origin of your car,
You can expect to increase the statistics of the part by 0.1
Engine - Top Speed and Acceleration / Tires - Acceleration
Brakes - Control / Turbo - Top Speed

Your car always starts from the bottom lane.
Thanks to a special bumper you will always find it quickly on the track !

           .-'--'-._
***********'-O---O--'>

Page 7/7       EXIT -> NR 0
";

            int Page = 1;
            bool start = true;

            Console.WriteLine(Page1);
            while (start)
            {
                string enter = Console.ReadLine();
                if (enter == "") { Page = 0; }
                else
                {
                    Page = int.Parse(enter);
                }

                while (Page < 0 || Page > 7)
                {
                    Console.WriteLine("Wrong number!");
                    Page = int.Parse(Console.ReadLine());
                }

                switch (Page)
                {
                    case 0:
                        start = false; break;
                    case 1:
                        Console.Clear(); Console.WriteLine(Page1); break;
                    case 2:
                        Console.Clear(); Console.WriteLine(Page2); break;
                    case 3:
                        Console.Clear(); Console.WriteLine(Page3); break;
                    case 4:
                        Console.Clear(); Console.WriteLine(Page4); break;
                    case 5:
                        Console.Clear(); Console.WriteLine(Page5); break;
                    case 6:
                        Console.Clear(); Console.WriteLine(Page6); break;
                    case 7:
                        Console.Clear(); Console.WriteLine(Page7); break;
                    default:
                        Console.Clear(); Console.WriteLine("WRONG NUMBER !"); break;
                }
            }
        }
    }
}
