using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6SAcademyCupManager {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void ApplyTeams_Click(object sender, EventArgs e) {
            /*Team Namen in die übersicht*/{
                TT1.Text = T1.Text;
                T1.ReadOnly = true;
                TT2.Text = T2.Text;
                T2.ReadOnly = true;
                TT3.Text = T3.Text;
                T3.ReadOnly = true;
                TT4.Text = T4.Text;
                T4.ReadOnly = true;
                TT5.Text = T5.Text;
                T5.ReadOnly = true;
                TT6.Text = T6.Text;
                T6.ReadOnly = true;
                TT7.Text = T7.Text;
                T7.ReadOnly = true;
                TT8.Text = T8.Text;
                T8.ReadOnly = true;
                TT9.Text = T9.Text;
                T9.ReadOnly = true;
                TT10.Text = T10.Text;
                T10.ReadOnly = true;
                TT11.Text = T11.Text;
                T11.ReadOnly = true;
                TT12.Text = T12.Text;
                T12.ReadOnly = true;
                TT13.Text = T13.Text;
                T13.ReadOnly = true;
                TT14.Text = T14.Text;
                T14.ReadOnly = true;
                TT15.Text = T15.Text;
                T15.ReadOnly = true;
                TT16.Text = T16.Text;
                T16.ReadOnly = true;
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            T1.ReadOnly = false;
            T2.ReadOnly = false;
            T3.ReadOnly = false;
            T4.ReadOnly = false;
            T5.ReadOnly = false;
            T6.ReadOnly = false;
            T7.ReadOnly = false;
            T8.ReadOnly = false;
            T9.ReadOnly = false;
            T10.ReadOnly = false;
            T11.ReadOnly = false;
            T12.ReadOnly = false;
            T13.ReadOnly = false;
            T14.ReadOnly = false;
            T15.ReadOnly = false;
            T16.ReadOnly = false;
        }
    }
}
