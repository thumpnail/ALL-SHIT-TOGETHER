using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {

        public static string[] filename;
        public static string file = "Z:/Gaming/Desktop/gta 5/gta 5/";
        public static string saveFile = "Z:/Gaming/Desktop/gta 5/gta 5/SAVE.txt";


        public Form1() {
            //create save
            if (!File.Exists(saveFile)) {
                File.Create(saveFile);
            }
            FileStream fs = new FileStream(saveFile, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);
            InitializeComponent();
        }

        public void GetAllFiledirectories() {
            filename = Directory.GetFiles(file, "*.*", SearchOption.AllDirectories);
        }

        //generate SAVE
        public void button1_Click(object sender, EventArgs e) {
            for (int i = 0; i < filename.Length; i++) {
                
            }

            File.WriteAllLines(saveFile, filename);
        }

        //Read all filenames
        public void button1_Click_1(object sender, EventArgs e) {
            GetAllFiledirectories();
        }
    }
}
