using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulatorPieca
{
    public partial class Form1 : Form
    {
        public int ruszt = 0;
        public bool ruszt_start = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer_ruszt.Stop();
            timer_ruszt.Interval = 1000;
            timer_ruszt.Start();
        }

        private void timer_ruszt_Tick(object sender, EventArgs e)
        {
            if (ruszt_start)
            {
                if (ruszt < 100)
                {
                    ruszt += 10;
                    progressBar1.Value = ruszt;
                }
                else
                {
                    ruszt = 0;
                    progressBar1.Value = ruszt;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer_ruszt.Stop();
            timer_ruszt.Interval = 2000;
            timer_ruszt.Start();
        }

        private void button_ruszt_start_Click(object sender, EventArgs e)
        {
            ruszt_start = true;
            ruszt = 0;
            timer_ruszt.Start();
        }

        private void button_ruszt_stop_Click(object sender, EventArgs e)
        {
            ruszt_start = false;
        }
    }
}
