using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapierAI {
    class RUNTIME {
        static void Main(string[] args) {
            bool runtime = true;

            while (runtime) {
                Game.Players_Turn();
                CALC.CALC_ALL();
                Game.Return_Game_Stats();
            }
        }
    }
}
