using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapierAI {
    class Database {
        //alle züge von player und AI gespeichert

        //Player
        public static int player_moves = 0;

        public static int player_schere = 0;
        public static int player_stein = 0;
        public static int player_papier = 0;

        public static double player_stat_durchschnitt_schere = 0.0;
        public static double player_stat_durchschnitt_stein = 0.0;
        public static double player_stat_durchschnitt_papier = 0.0;

        //AI

        public static int ai_moves = 0;

        public static int ai_schere = 0;
        public static int ai_stein = 0;
        public static int ai_papier = 0;

        public static double ai_stat_durchschnitt_schere = 0.0;
        public static double ai_stat_durchschnitt_stein = 0.0;
        public static double ai_stat_durchschnitt_papier = 0.0;
    }
}
