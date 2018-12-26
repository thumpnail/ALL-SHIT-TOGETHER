using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GTA_5_mod_installer_n3x
{
    class Program {

        public static string[] filename;
        public static string file = "Z:/Gaming/Desktop/gta 5/gta 5/";
        public static string saveFile = "Z:/Gaming/Desktop/gta 5/gta 5/SAVE.txt";
        public static string gtaBin = "Y:/_programm daten/SteamLibrary/steamapps/common/Grand Theft Auto V/";

        static void Main() {
            FileStream fs = new FileStream(saveFile, FileMode.OpenOrCreate); {
                StreamReader sr = new StreamReader(fs);
                StreamWriter sw = new StreamWriter(fs);

                GetAllFileNames();

                for (int i = 0; i < filename.Length; i++) {
                    Console.WriteLine(filename[i]);
                }

                //write to file
                if (!File.Exists(saveFile)) {
                    File.Create(saveFile);
                }

                fs.Close();
                CONSOLE();

            }

            File.WriteAllLines(saveFile, filename);

            Console.ReadKey();
        }

        static void CONSOLE() {
            bool still_in_console = true;
            do {
                string command = "";
                Console.WriteLine();
                Console.WriteLine("readsave");
                Console.WriteLine("install");
                Console.WriteLine("deinstall");
                Console.WriteLine("clear");
                Console.WriteLine();

                command = Console.ReadLine();

                if (command.Equals("readsave")) {
                    TXTtoARRAY();
                } else if (command.Equals("install")) {
                    Install();
                } else if (command.Equals("deinstall")) {
                    Desinstall();
                } else if (command.Equals("clear")) {
                    Console.Clear();
                }

            } while (still_in_console);
        }



        static void GetAllFileNames() {
            filename = Directory.GetFiles(file, "*.*", SearchOption.AllDirectories);
        }

        static void Update() {
            if (File.Exists(saveFile)) {
                File.Delete(saveFile);
            }
            FileStream fs = new FileStream(saveFile, FileMode.OpenOrCreate); {
                StreamReader sr = new StreamReader(fs);
                StreamWriter sw = new StreamWriter(fs);
                GetAllFileNames();

                for (int i = 0; i < filename.Length; i++) {
                    Console.WriteLine(filename[i]);
                }

                //write to file
                if (!File.Exists(saveFile)) {
                    File.Create(saveFile);
                }

                fs.Close();
            }
        }

        static void Install() {
            
            FileStream fs = new FileStream(saveFile, FileMode.OpenOrCreate);
            {
                StreamReader sr = new StreamReader(fs);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < filename.Length; i++) {
                    File.Copy()
                }

            }
            }

        static void Desinstall() {

        }
        
        static void TXTtoARRAY() {
            FileStream fs = new FileStream(saveFile, FileMode.OpenOrCreate);
            {
                StreamReader sr = new StreamReader(fs);
                StreamWriter sw = new StreamWriter(fs);

                //alles mit null beschreiben
                //for (int i = 0; i < filename.Length; i++) {
                //    filename[i] = null;
                //}

                string line = "";
                int index = 0;

                //lese und schreibe in den array
                while ((line = sr.ReadLine()) != null) {
                    filename[index] = line;
                    index++;
                }

                Console.WriteLine("Alles im array: ");

                //ausgeben
                for (int i = 0; i < filename.Length; i++) {
                    Console.WriteLine(filename[i]);
                }

                fs.Close();
            }
        }
    }
}
