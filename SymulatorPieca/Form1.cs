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
        public int fan1_speed = 0;
        public int pompa_zimna = 0;
        public int pompa_ciepla = 0;
        public int woda_zimna = 30;
        public int woda_ciepla = 80;
        public int temp_palenisko = 0;
        public int ruszt_speed = 0;

        public bool rozpalony = false;
        public bool zalogowany = true;
        public bool ruszt_start = false;
        public bool awaria_ruszt = false;
        public bool awaria_pomp = false;
        public bool awaria_went = false;

        public Random randomizer = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer_ruszt.Stop();
            timer_ruszt.Interval = 1000;
            ruszt_speed = 200;
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
            ruszt_speed = 100;
            timer_ruszt.Start();
        }

        private void button_ruszt_start_Click(object sender, EventArgs e)
        {
            ruszt_start = true;
            ruszt = 0;
            if (radioButton1.Checked) ruszt_speed = 200;
            else ruszt_speed = 100;
            timer_ruszt.Start();
        }

        private void button_ruszt_stop_Click(object sender, EventArgs e)
        {
            ruszt_start = false;
            ruszt_speed = 0;
        }

        private void trackBar_pompazim_Scroll(object sender, EventArgs e)
        {
            label_pompazim.Text = "Pompa zimna: " + (trackBar_pompazim.Value * 100).ToString() + " RPM";
            pompa_zimna = trackBar_pompazim.Value * 100;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_pompaciep.Text = "Pompa ciepła: " + (trackBar1.Value * 100).ToString() + " RPM";
            pompa_ciepla = trackBar1.Value * 100;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label_fan1.Text = "Fan 1: " + (trackBar3.Value * 100).ToString() + " RPM";
            fan1_speed = trackBar3.Value * 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_symulacja_Tick(object sender, EventArgs e)
        {
            if(rozpalony) //czy palenisko zostało rozpalone?
            {
                if (ruszt_speed > 0 && fan1_speed > 0) //jezeli wentylator i ruszt pracują to zwiekszamy temperature
                {
                    if (temp_palenisko < ruszt_speed + fan1_speed) //po przekroczeniu pewnej temp. nie zwiekszamy juz
                    {
                        double ruszt = ruszt_speed * 0.1;
                        double fans = fan1_speed * 0.1;
                        temp_palenisko = temp_palenisko + Convert.ToInt32(ruszt) + Convert.ToInt32(fans);
                    }
                    else
                    {
                        temp_palenisko = ruszt_speed + fan1_speed; //drobne wahania temp. dla realizmu
                        int znak = randomizer.Next(0, 1);
                        if (znak == 0) znak = -1;
                        temp_palenisko += znak * randomizer.Next(0, 100);
                    }
                }
                else
                {
                    if (temp_palenisko > 0) 
                        temp_palenisko = temp_palenisko - (200 - ruszt_speed) - Convert.ToInt32(fan1_speed*0.01) - 100; //wygaszanie paleniska, do poprawki
                    else
                    {
                        temp_palenisko = 0;
                        rozpalony = false; //palenisko wygasło
                    }
                }
                label_palenisko.Text = temp_palenisko.ToString()+" C";
            }
            else
            {
                temp_palenisko = 0;
                label_palenisko.Text = temp_palenisko.ToString() + " C";
            }


        }

        private void button_rozpal_Click(object sender, EventArgs e)
        {
            temp_palenisko = 400;
            rozpalony = true; //rozpalamy
        }
    }
}
