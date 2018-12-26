using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapierAI {
    class Game {
        //ansammlung von metoden die das gameplay beeinflussen

        public static void Players_Turn() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Schere(1), Stein(2) oder Papier(3)?");
            Console.ForegroundColor = ConsoleColor.White;

            string key = Console.ReadLine();
            
            if (key.Equals("1")) {
                Console.WriteLine("Schere");
                Database.player_schere++;
                Database.player_moves++;
            } else if (key.Equals("2")) {
                Console.WriteLine("Stein");
                Database.player_stein++;
                Database.player_moves++;
            } else if (key.Equals("3")) {
                Console.WriteLine("Papier");
                Database.player_papier++;
                Database.player_moves++;
            } else {
                Console.WriteLine("Error");
            }
        }

        public static int AI_Turn() {

            return 0;
        }

        public static void Return_Game_Stats() {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("Spiele gespielt: ");
            Console.WriteLine(Database.player_moves);
            Console.Write("Durchscnitt schere: ");
            Console.WriteLine(Database.player_stat_durchschnitt_schere);
            Console.Write("Durchscnitt stein: ");
            Console.WriteLine(Database.player_stat_durchschnitt_stein);
            Console.Write("Durchscnitt papier: ");
            Console.WriteLine(Database.player_stat_durchschnitt_papier);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
