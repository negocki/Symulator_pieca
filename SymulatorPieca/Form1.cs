using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SymulatorPieca
{
    public partial class Form1 : Form
    {
        public int ruszt = 0;
        public int fan1_speed = 0;
        public int pompa_zimna = 0;
        public int pompa_ciepla = 0;
        public int woda_zimna = 30;
        public int woda_ciepla = 30;
        public int temp_palenisko = 0;
        public int ruszt_speed = 0;
        public int czuwak = 60;

        public bool rozpalony = false;
        public bool zalogowany = false;
        public bool ruszt_start = false;
        public bool awaria_ruszt = false;
        public bool awaria_pomp = false;
        public bool awaria_went = false;

        public Logowanie dialog_logowanie = new Logowanie();
        public Random randomizer = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //szybki ruszt
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
                    progressBar1.Value = ruszt; //zmieniamy progress bar rusztu od 0 do 100 i tak w koło
                }
                else
                {
                    ruszt = 0;
                    progressBar1.Value = ruszt;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //wolny ruszt
        {
            timer_ruszt.Stop();
            timer_ruszt.Interval = 2000;
            ruszt_speed = 100;
            timer_ruszt.Start();
        }

        private void button_ruszt_start_Click(object sender, EventArgs e) //start rusztu
        {
            ruszt_start = true;
            ruszt = 0;
            if (radioButton1.Checked) ruszt_speed = 200;
            else ruszt_speed = 100;
            timer_ruszt.Start();
        }

        private void button_ruszt_stop_Click(object sender, EventArgs e) //stop ruszt
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
            label_fan2.Text = "Fan 2: " + (trackBar3.Value * 100).ToString() + " RPM";
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
                        woda_ciepla = woda_ciepla + Convert.ToInt32(pompa_ciepla * 0.01 * temp_palenisko * 0.001) + Convert.ToInt32(pompa_zimna * 0.001);
                        woda_zimna = Convert.ToInt32(0.4 * woda_ciepla);
                    }
                    else
                    {
                        temp_palenisko = ruszt_speed + fan1_speed; //drobne wahania temp. dla realizmu
                        int znak = randomizer.Next(0, 1);
                        if (znak == 0) znak = -1;
                        temp_palenisko += znak * randomizer.Next(0, 100);
                        woda_ciepla += znak * randomizer.Next(0, 10);
                    }
                }
                else
                {
                    if (temp_palenisko > 0) 
                        temp_palenisko = temp_palenisko - Convert.ToInt32((200 - ruszt_speed)*0.2) - Convert.ToInt32(fan1_speed*0.01) - 50; //wygaszanie paleniska, do poprawki
                    else
                    {
                        temp_palenisko = 0;
                        rozpalony = false; //palenisko wygasło
                    }

                    if(woda_ciepla > 30)
                    {
                        woda_ciepla = woda_ciepla - Convert.ToInt32(0.1 * pompa_zimna * 0.01) - Convert.ToInt32(0.01 * pompa_ciepla * 0.01); //woda robi sie zimniejsza
                    }
                }
                label_palenisko.Text = temp_palenisko.ToString()+" C";
                label_wodaciep.Text = woda_ciepla.ToString() + " C";
                label_wodazim.Text = woda_zimna.ToString() + " C";
            }
            else
            {
                if (woda_ciepla > 30)
                {
                    woda_ciepla = woda_ciepla - Convert.ToInt32(0.1 * pompa_zimna * 0.1) - Convert.ToInt32(0.01 * pompa_ciepla * 0.01); //woda robi sie zimniejsza
                    woda_zimna = Convert.ToInt32(0.4 * woda_ciepla);
                }
                temp_palenisko = 0;
                label_palenisko.Text = temp_palenisko.ToString() + " C";
                label_wodaciep.Text = woda_ciepla.ToString() + " C";
                label_wodazim.Text = woda_zimna.ToString() + " C";
            }


        }

        private void button_rozpal_Click(object sender, EventArgs e)
        {
            temp_palenisko = 400;
            rozpalony = true; //rozpalamy
        }

        private void timer_awaria_Tick(object sender, EventArgs e)
        {
            int awaria = randomizer.Next(0,3); //czy nastapila awaria?
            if(awaria == 1)
            {
                //informacja o awarii

                MessageBox.Show("Nastapila awaria!",
                 "Awaria",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

                int co_zepsute = randomizer.Next(0, 3); //wybieramy co sie zepsuło

                if(co_zepsute == 0) //awaria rusztu
                {
                    listBox_awarie.Items.Add("<" + DateTime.Now + "> " + "Awaria rusztu");
                    listBox_awarie.TopIndex = listBox_awarie.Items.Count - 1;
                    label_ruszt_awaria.Visible = true;
                    ruszt_speed = 0;
                    button_ruszt_start.Enabled = false;
                    button_ruszt_stop.Enabled = false;
                    button_awariaruszt.Enabled = true;
                }
                else if(co_zepsute == 1) //awaria wentylatorów
                {
                    listBox_awarie.Items.Add("<" + DateTime.Now + "> " + "Awaria wentylatorów");
                    listBox_awarie.TopIndex = listBox_awarie.Items.Count - 1;
                    label_went_awaria.Visible = true;
                    trackBar3.Enabled = false;
                    fan1_speed = 0;
                    trackBar3.Value = 0;
                    button_awaria_went.Enabled = true;
                }
                else if(co_zepsute == 2) //awaria pomp
                {
                    listBox_awarie.Items.Add("<" + DateTime.Now + "> " + "Awaria pomp");
                    listBox_awarie.TopIndex = listBox_awarie.Items.Count - 1;
                    label_pompy_awaria.Visible = true;
                    button_awariapomp.Enabled = true;
                    pompa_zimna = 0;
                    pompa_ciepla = 0;
                    trackBar_pompazim.Enabled = false;
                    trackBar_pompazim.Value = 0;
                    trackBar1.Enabled = false;
                    trackBar1.Value = 0;
                }
            }
        }

        private void button_awariaruszt_Click(object sender, EventArgs e) //naprawa rusztu
        {
            listBox_awarie.Items.Add("<" + DateTime.Now + "> " + "Naprawiono");
            listBox_awarie.TopIndex = listBox_awarie.Items.Count - 1;
            label_ruszt_awaria.Visible = false;
            button_ruszt_start.Enabled = true;
            button_ruszt_stop.Enabled = true;
            button_awariaruszt.Enabled = false;
        }

        private void button_awaria_went_Click(object sender, EventArgs e) //naprawiamy wentylatory
        {
            listBox_awarie.Items.Add("<" + DateTime.Now + "> " + "Naprawiono");
            listBox_awarie.TopIndex = listBox_awarie.Items.Count - 1;
            label_went_awaria.Visible = false;
            trackBar3.Enabled = true;
            button_awaria_went.Enabled = false;
        }

        private void button_awariapomp_Click(object sender, EventArgs e)
        {
            listBox_awarie.Items.Add("<" + DateTime.Now + "> " + "Naprawiono");
            listBox_awarie.TopIndex = listBox_awarie.Items.Count - 1;
            label_pompy_awaria.Visible = false;
            button_awariapomp.Enabled = false;
            pompa_zimna = 0;
            pompa_ciepla = 0;
            trackBar_pompazim.Enabled = true;
            trackBar_pompazim.Value = 0;
            trackBar1.Enabled = true;
            trackBar1.Value = 0;
        }

        private void timer_czuwak_Tick(object sender, EventArgs e)
        {
            if(czuwak > 0)
            {
                czuwak--;
                label_czuwak.Text = "Czuwak: " + czuwak.ToString() + " s";
            }
            else
            {
                SystemSounds.Beep.Play();
                Czuwak czuw = new Czuwak();
                czuw.Show();
                czuwak = 60;
            }

            if(!Zalogowany.zalogowany) //jezeli dialog ustawil zalogowany na false to wylogowujemy
            {
               
                    MessageBox.Show("Operator wylogowany z powodu nieobecności!",
                    "Wylogowano",
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button1);

                    button_ruszt_start.Enabled = false;
                    button_ruszt_stop.Enabled = false;
                    trackBar3.Enabled = false;
                    trackBar_pompazim.Enabled = false;
                    trackBar1.Enabled = false;
                    button_rozpal.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    timer_awaria.Enabled = false;
                    timer_czuwak.Enabled = false;
                    ruszt_start = false;
                    czuwak = 60;
                    label_czuwak.Text = "Czuwak: 60 s";
                    Zalogowany.zalogowany = false;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog_logowanie.ShowDialog();
            if(Zalogowany.zalogowany)
            {
                //obsluga zalogowania
                button_ruszt_start.Enabled = true;
                button_ruszt_stop.Enabled = true;
                trackBar3.Enabled = true;
                trackBar_pompazim.Enabled = true;
                trackBar1.Enabled = true;
                button_rozpal.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                timer_awaria.Enabled = true;
                timer_czuwak.Enabled = true;


            }
        }

        private void button2_Click(object sender, EventArgs e) //wylogowanie
        {
            MessageBox.Show("Operator wylogowany!",
                 "Wylogowano",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            button_ruszt_start.Enabled = false;
            button_ruszt_stop.Enabled = false;
            trackBar3.Enabled = false;
            trackBar_pompazim.Enabled = false;
            trackBar1.Enabled = false;
            button_rozpal.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            timer_awaria.Enabled = false;
            timer_czuwak.Enabled = false;
            ruszt_start = false;
            czuwak = 60;
            label_czuwak.Text = "Czuwak: 60 s";
            Zalogowany.zalogowany = false;
        }
    }
}
