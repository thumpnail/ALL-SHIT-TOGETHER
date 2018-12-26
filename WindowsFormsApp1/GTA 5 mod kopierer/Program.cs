using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GTA_5_mod_kopierer {
    class Program {

        public static string[] filename;
        public static string file = "Z:/Gaming/Desktop/gta 5/gta 5/";
        public static string saveFile = "Z:/Gaming/Desktop/gta 5/gta 5/SAVE.txt";

        static void Main(string[] args) {
            if (!File.Exists(saveFile)) {
                File.Create(saveFile);
            }

            FileStream fs = new FileStream(saveFile, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);

        }

        public static void GenerateSave() {
            
        }

        public static void GetAllFilenames() {

        }
    }
}
