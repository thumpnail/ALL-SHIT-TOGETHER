using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapierAI {
    class CALC {


        public static void CALC_ALL() {
            CLAC_player_stat_durchschnitt_schere();
            CALC_player_stat_durchschnitt_stein();
            CALC_player_stat_durchschnitt_papier();
        }


        public static void CLAC_player_stat_durchschnitt_schere() {
            Database.player_stat_durchschnitt_schere =  Convert.ToDouble(Database.player_schere) / Convert.ToDouble(Database.player_moves) * 100;
        }

        public static void CALC_player_stat_durchschnitt_stein() {
            Database.player_stat_durchschnitt_stein = Convert.ToDouble(Database.player_stein) / Convert.ToDouble(Database.player_moves) * 100;
        }

        public static void CALC_player_stat_durchschnitt_papier() {
            Database.player_stat_durchschnitt_papier = Convert.ToDouble(Database.player_papier) / Convert.ToDouble(Database.player_moves) * 100;
        }

        public static void CALC_get_high_value() {
            
        }
    }
}
