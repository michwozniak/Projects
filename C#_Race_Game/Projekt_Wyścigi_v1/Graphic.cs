using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Wyścigi_v1
{
    public class Graphic
    {
        static string Title = @"
  __________                _____                    _________   __________                _____                        
  ___  ____/______ ___________  /_   ______ ________ ______  /   ___  ____/____  _____________(_)______ ____  __________
  __  /_    _  __ `/__  ___/_  __/   _  __ `/__  __ \_  __  /    __  /_    _  / / /__  ___/__  / _  __ \_  / / /__  ___/
  _  __/    / /_/ / _(__  ) / /_     / /_/ / _  / / // /_/ /     _  __/    / /_/ / _  /    _  /  / /_/ // /_/ / _(__  ) 
  /_/       \__,_/  /____/  \__/     \__,_/  /_/ /_/ \__,_/      /_/       \__,_/  /_/     /_/   \____/ \__,_/  /____/
                   

                                       ___..................____
                              _..--''~_______   _____...----~~~\\
                          __.'    .-'~       \\~      [_`\.     \\
                    .---~~      .'            \\           __..--\\_
                   /             `-._          \\   _...~~~_..---~  ~~~~~~~~~~~~--.._
                   \              /  ~~~~~~----_\`-~_-~~__          ~~~~~~~---.._    ~--.__
                    \     _       |==            |   ~--___--------...__          `-   _.-- |
                     \ __/.-._\   |              |            ~~~~--.  `-._ ___...--~~~_.'|_Y |
                      `--'|/~_\\  |              |     _____           _.~~~__..--~~_.-~~~.-~/
                        | ||| |\\_|__            |.../.----.._.        | Y |__...--~~_.-~_//
                         ~\\\ || ~|..__---____   |||||  .'~-. \\       |_..-----~~~~   _.~~
                           \`-'/ /     ~~~----...|'''|  |/"" \  \   |~~'           __.~
                            ~~~'                 ~~-:.  ||~|  |\\  |        __..~~
                                                     '~~|||  | | \\/  _.---~~
                                                        \\\  //  | ~~~
                                                         \`-'/  / 
                                                          `~~~~'";      
        static string Title2 = @"

 ______           _                       _  ______             _                    
 |  ___|         | |                     | | |  ___|           (_)                   
 | |_  __ _  ___ | |_    __ _  _ __    __| | | |_  _   _  _ __  _   ___   _   _  ___ 
 |  _|/ _` |/ __|| __|  / _` || '_ \  / _` | |  _|| | | || '__|| | / _ \ | | | |/ __|
 | | | (_| |\__ \| |_  | (_| || | | || (_| | | |  | |_| || |   | || (_) || |_| |\__ \
 \_|  \__,_||___/ \__|  \__,_||_| |_| \__,_| \_|   \__,_||_|   |_| \___/  \__,_||___/
";
 
        public static void ShowAnimationWin()
        {
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 3 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 2 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 1 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'\n");
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-o---o--'\n");
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'\n");
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ****'-O---O--'\n");
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'\n");
            Console.WriteLine("          .-'--`-._");
            Console.WriteLine("   *******'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-o---o--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-o---o--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   **********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-o---o--'\n");
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-O---O--'>\n\n"); 
            System.Threading.Thread.Sleep(100);


            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-o---o--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-o---o--'\n");
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("               .-'--'-._");
            Console.WriteLine("   ************'-o---o--'\n");
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-o---o--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-o---o--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-o---o--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("               .-'--'-._");
            Console.WriteLine("   ************'-O---O--'>\n\n");


            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("                .-'--'-._");
            Console.WriteLine("   *************'-o---o--\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("                 .-'--'-.");
            Console.WriteLine("   **************'-o---o-\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("                  .-'--'-");
            Console.WriteLine("   ***************'-o---o\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'\n");
            Console.WriteLine("                   .-'--'");
            Console.WriteLine("   ****************'-o---\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'\n");
            Console.WriteLine("                    .-'--");
            Console.WriteLine("   *****************'-o--\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'\n");
            Console.WriteLine("                     .-'-");
            Console.WriteLine("   ******************'-o-\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n");
            Console.WriteLine("                      .-'");
            Console.WriteLine("   *******************'-o\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n");
            Console.WriteLine("                       .-");
            Console.WriteLine("   ********************'-\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n");
            Console.WriteLine("                        .");
            Console.WriteLine("   *********************'\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-o---o--'\n");
            Console.WriteLine("                        ");
            Console.WriteLine("   *********************\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-o---o--'\n");
            Console.WriteLine("                      ");
            Console.WriteLine("   *******************\n\n");
            Console.WriteLine("                                \n");
            Console.WriteLine("     W       W  II  N       N   ");
            Console.WriteLine("     W       W  II  N N     N   ");
            Console.WriteLine("     W       W  II  N  N    N   ");
            Console.WriteLine("     W       W  II  N   N   N   ");
            Console.WriteLine("     W   W   W  II  N    N  N   ");
            Console.WriteLine("     W W   W W  II  N     N N   ");
            Console.WriteLine("     W       W  II  N       N   ");

            System.Threading.Thread.Sleep(500);
        }
        public static void ShowAnimationLoss()
        {
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 3 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 2 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 1 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'\n");
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-o---o--'\n");
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'\n");
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'\n");
            Console.WriteLine("       .-'--`-._");
            Console.WriteLine("   ****'-O---O--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--`-._");
            Console.WriteLine("   *******'-O---O--'\n");
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'\n");
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   **********'-O---O--'\n");
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-O---O--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);


            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'\n");
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-O---O--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-O---O--'\n");
            Console.WriteLine("               .-'--'-._");
            Console.WriteLine("   ************'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'\n");
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'\n");
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("               .-'--'-._");
            Console.WriteLine("   ************'-O---O--'\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'>\n");
            


            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                .-'--'-._");
            Console.WriteLine("   *************'-o---o--\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                 .-'--'-.");
            Console.WriteLine("   **************'-o---o-\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                  .-'--'-");
            Console.WriteLine("   ***************'-o---o\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                   .-'--'");
            Console.WriteLine("   ****************'-o---\n");
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                    .-'--");
            Console.WriteLine("   *****************'-o--\n");
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                     .-'-");
            Console.WriteLine("   ******************'-o-\n");
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      .-'");
            Console.WriteLine("   *******************'-o\n");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                       .-");
            Console.WriteLine("   ********************'-\n");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        .");
            Console.WriteLine("   *********************'\n");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   *********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-o---o--'>\n");
            
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("                      ");
            Console.WriteLine("   *******************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-o---o--'>\n\n");
            
            Console.WriteLine("                                                 \n");
            Console.WriteLine("  L         O O O       S S S S       S S S S      ");
            Console.WriteLine("  L       O       O   S             S              ");
            Console.WriteLine("  L      O         O   S             S             ");
            Console.WriteLine("  L      O         O     S S           S S         ");
            Console.WriteLine("  L      O         O         S             S       ");
            Console.WriteLine("  L       O       O          S             S       ");
            Console.WriteLine("  L L L L   O O O    S S S S       S S S S         ");

            System.Threading.Thread.Sleep(500);
        }

        public static void ShowAnimationTurbo()
        {
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 3 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 2 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 1 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'\n");
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-o---o--'\n");
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'\n");
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--`-._");
            Console.WriteLine("   ****'-O---O--'\n");
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'\n");
            Console.WriteLine("          .-'--`-._");
            Console.WriteLine("   *******'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("                .-'--'-._");
            Console.WriteLine("   *************'-O---O--'>\n\n");


            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n");
            Console.WriteLine("                .-'--'-._");
            Console.WriteLine("   *************'-o---o--\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'\n");
            Console.WriteLine("                 .-'--'-.");
            Console.WriteLine("   **************'-o---o-\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-o---o--'\n");
            Console.WriteLine("                  .-'--'-");
            Console.WriteLine("   ***************'-o---o\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n");
            Console.WriteLine("                   .-'--'");
            Console.WriteLine("   ****************'-o---\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n");
            Console.WriteLine("                    .-'--");
            Console.WriteLine("   *****************'-o--\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n");
            Console.WriteLine("                     .-'-");
            Console.WriteLine("   ******************'-o-\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-o---o--'\n");
            Console.WriteLine("                      .-'");
            Console.WriteLine("   *******************'-o\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-o---o--'\n");
            Console.WriteLine("                       .-");
            Console.WriteLine("   ********************'-\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-o---o--'\n");
            Console.WriteLine("                        .");
            Console.WriteLine("   *********************'\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("    .-'--'-._");
            Console.WriteLine("   *'-o---o--'\n");
            Console.WriteLine("                        ");
            Console.WriteLine("   *********************\n\n");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("    .-'--'-._");
            Console.WriteLine("   *'-o---o--'\n");
            Console.WriteLine("                      ");
            Console.WriteLine("   *********************\n\n");
            Console.WriteLine("                                \n");
            Console.WriteLine("     W       W  II  N       N   ");
            Console.WriteLine("     W       W  II  N N     N   ");
            Console.WriteLine("     W       W  II  N  N    N   ");
            Console.WriteLine("     W       W  II  N   N   N   ");
            Console.WriteLine("     W   W   W  II  N    N  N   ");
            Console.WriteLine("     W W   W W  II  N     N N   ");
            Console.WriteLine("     W       W  II  N       N   ");

            System.Threading.Thread.Sleep(500);
        }
        public static void ShowAnimationEngine()
        {
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n 3 .-'--'-._");
            Console.WriteLine("   '-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n 2 .-'--'-._");
            Console.WriteLine("   '-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n 1 .-'--'-._");
            Console.WriteLine("   '-o---o--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n    .-'--'-._");
            Console.WriteLine("   *'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n     .-'--'-._");
            Console.WriteLine("   **'-o---o--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n      .-'--'-._");
            Console.WriteLine("   ***'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n        .-'--'-._");
            Console.WriteLine("   *****'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n          .-'--'-._");
            Console.WriteLine("   *******'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n               .-'--'-._");
            Console.WriteLine("   ************'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                 .-'--'-._");
            Console.WriteLine("   **************'-O---O--'");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                   .-'--'-");
            Console.WriteLine("   ****************'-O---O-");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                    .-'--");
            Console.WriteLine("   *****************'-O---");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                     .-'");
            Console.WriteLine("   ******************'-O-");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                      .");
            Console.WriteLine("   *******************'-");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                       ");
            Console.WriteLine("   ********************");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                      ");
            Console.WriteLine("   *******************");
            Console.WriteLine("   .-'--'-._X");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                      ");
            Console.WriteLine("   *******************");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n                      ");
            Console.WriteLine("   ********I I********");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n          O    O      ");
            Console.WriteLine("   ********I I********");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n          O    O      ");
            Console.WriteLine("   ********I I********");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n          OO  OO      ");
            Console.WriteLine("   ********I I********");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("\n          OOOOOO      ");
            Console.WriteLine("   ********IOI********");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            IO       ");
            Console.WriteLine("          OOOOOI       ");
            Console.WriteLine("   ********IOIO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OOOI       ");
            Console.WriteLine("          OOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIOI       ");
            Console.WriteLine("          OIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          IOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IOOI       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          IOIIIO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIIO       ");
            Console.WriteLine("          OOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          OIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          IOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IOOI       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIIO       ");
            Console.WriteLine("          IOIIIO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OOII       ");
            Console.WriteLine("          OOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIOI       ");
            Console.WriteLine("          IIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIOO       ");
            Console.WriteLine("          IOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIIO       ");
            Console.WriteLine("          IOIIOO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          IOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          OIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIOO       ");
            Console.WriteLine("          OOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIOI       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          IOIIIO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          IOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IOOI       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          IOIIIO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIIO       ");
            Console.WriteLine("          OOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          OIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          IOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IOOI       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIIO       ");
            Console.WriteLine("          IOIIIO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OOII       ");
            Console.WriteLine("          OOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIOI       ");
            Console.WriteLine("          IIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIOO       ");
            Console.WriteLine("          IOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIIO       ");
            Console.WriteLine("          IOIIOO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIII       ");
            Console.WriteLine("          IOIOIO       ");
            Console.WriteLine("   ********IOOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          OIOOIO       ");
            Console.WriteLine("   ********IIOO*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIOO       ");
            Console.WriteLine("          OOIOOI       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           OIOI       ");
            Console.WriteLine("          OIIOII       ");
            Console.WriteLine("   ********IIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("           IIII       ");
            Console.WriteLine("          IOIIIO       ");
            Console.WriteLine("   ********OIOI*******");
            Console.WriteLine("   .-'--'-._V");
            Console.WriteLine("   '-o---o--'>\n");

            Console.WriteLine("                                                 \n");
            Console.WriteLine("  L         O O O       S S S S       S S S S      ");
            Console.WriteLine("  L       O       O   S             S              ");
            Console.WriteLine("  L      O         O   S             S             ");
            Console.WriteLine("  L      O         O     S S           S S         ");
            Console.WriteLine("  L      O         O         S             S       ");
            Console.WriteLine("  L       O       O          S             S       ");
            Console.WriteLine("  L L L L   O O O    S S S S       S S S S         ");

            System.Threading.Thread.Sleep(500);
        }
        public static void ShowAnimationTires()
        {
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 3 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 2 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine(" 1 .-'--'-._");
            Console.WriteLine("   '-O---O--'\n");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'>\n\n");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'\n");
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-o---o--'\n");
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'\n");
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'>\n\n");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'\n");
            Console.WriteLine("       .-'--`-._");
            Console.WriteLine("   ****'-O---O--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--`-._");
            Console.WriteLine("   *******'-O---O--'\n");
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'\n");
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   **********'-O---O--'\n");
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-O---O--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);


            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'\n");
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-O---O--'\n");
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-O---O--'\n");
            Console.WriteLine("               .-'--'-._");
            Console.WriteLine("   ************'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-O---O--'\n");
            Console.WriteLine("             .-'--'-._");
            Console.WriteLine("   **********'-o---o--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-O---O--'\n");
            Console.WriteLine("            .-'--'-._");
            Console.WriteLine("   *********'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'\n");
            Console.WriteLine("           .-'--'-._");
            Console.WriteLine("   ********'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("              .-'--'-._");
            Console.WriteLine("   ***********'-O---O--'\n");
            Console.WriteLine("          .-'--'-._");
            Console.WriteLine("   *******'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("               .-'--'-._");
            Console.WriteLine("   ************'-O---O--'\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-X---x--'>\n");



            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                .-'--'-._");
            Console.WriteLine("   *************'-o---o--\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                 .-'--'-.");
            Console.WriteLine("   **************'-o---o-\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                  .-'--'-");
            Console.WriteLine("   ***************'-o---o\n");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                   .-'--'");
            Console.WriteLine("   ****************'-o---\n");
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                    .-'--");
            Console.WriteLine("   *****************'-o--\n");
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                     .-'-");
            Console.WriteLine("   ******************'-o-\n");
            Console.WriteLine("        .-'--'-._");
            Console.WriteLine("   *****'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      .-'");
            Console.WriteLine("   *******************'-o\n");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                       .-");
            Console.WriteLine("   ********************'-\n");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        .");
            Console.WriteLine("   *********************'\n");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-x---X--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(Title2);
            Console.WriteLine("                        ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-X---x--'>\n");

            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("                      ");
            Console.WriteLine("   **********************\n");
            Console.WriteLine("      .-'--'-._");
            Console.WriteLine("   ***'-x---X--'>\n\n");

            Console.WriteLine("                                                 \n");
            Console.WriteLine("  L         O O O       S S S S       S S S S      ");
            Console.WriteLine("  L       O       O   S             S              ");
            Console.WriteLine("  L      O         O   S             S             ");
            Console.WriteLine("  L      O         O     S S           S S         ");
            Console.WriteLine("  L      O         O         S             S       ");
            Console.WriteLine("  L       O       O          S             S       ");
            Console.WriteLine("  L L L L   O O O    S S S S       S S S S         ");

            System.Threading.Thread.Sleep(500);
        }

        public static string ShowGraphic()
        {
            string Graphic_1 = @"              ____----------- _____               ____           __                  __  ____            _
\~~~~~~~~~~/~_--~~~------~~~~~     \             / __/___ _ ___ / /_  ___ _ ___  ___/ / / __/__ __ ____ (_)___  __ __ ___
 `---`\  _-~      |                   \         / _/ / _ `/(_-</ __/ / _ `// _ \/ _  / / _/ / // // __// // _ \/ // /(_-<
   _-~  <_         |                     \[]   /_/   \_,_//___/\__/  \_,_//_//_/\_,_/ /_/   \_,_//_/  /_/ \___/\_,_//___/
 / ___     ~~--[""] |      ________-------'_
> /~` \    |-.   `\~~.~~~~~                _ ~ - _
 ~|  ||\%  |       |    ~  ._                ~ _   ~ ._
   `_//|_%  \      |          ~  .              ~-_   /\
          `--__     |    _-____  /\               ~-_ \/.
               ~--_ /  ,/ -~-_ \ \/          _______---~/
                   ~~-/._<   \ \`~~~~~~~~~~~~~     ##--~/
                         \    ) |`------##---~~~~-~  ) )
                          ~-_/_/                  ~~ ~~
";
            Console.Clear();
            return Graphic_1;
        }
        public static void ShowGraphic2()
        {
            string Graphic_2 = Title;
            Console.Write(Graphic_2);
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
        }
        public static void ShowAnimation()
        {
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("   .-'--'-._");
            Console.WriteLine("   '-O---O--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("    .-'--`-._");
            Console.WriteLine("   *'-O---O--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("     .-'--'-._");
            Console.WriteLine("   **'-o---o--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("      .-'--`-._");
            Console.WriteLine("   ***'-O---O--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("       .-'--'-._");
            Console.WriteLine("   ****'-o---o--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("        .-'--`-._");
            Console.WriteLine("   *****'-O---O--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("         .-'--'-._");
            Console.WriteLine("   ******'-o---o--'\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("          .-'--`-.");
            Console.WriteLine("   *******'-O---O--\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("           .-'--'-");
            Console.WriteLine("   ********'-o---o-\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("            .-'--`");
            Console.WriteLine("   *********'-o---o\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("             .-'--");
            Console.WriteLine("   **********'-O---\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("              .-'-");
            Console.WriteLine("   ***********'-O--\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("               .-'-");
            Console.WriteLine("   ************'-O--\n\n");
            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("Fast end Furious");
            Console.WriteLine("                .-'-");
            Console.WriteLine("   *************'-O--\n\n");
        }
        public static void ShowAnimation2()
        {
            Console.Clear();
            Console.WriteLine(Title);
            System.Threading.Thread.Sleep(2000);
        }

        public static void Curiosities()
        {
            string Curiosities = @"

     Author:  Michał Woźniak

     Number of used classes: 37
          
     Number of lines written code: 4320

     Number of working hours: 60-70h

     Author of the two ASCI big cars: David Palmer

";
            Console.WriteLine(Curiosities);
            Console.ReadKey();
        }
    }
}
