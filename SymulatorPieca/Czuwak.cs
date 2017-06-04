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
    public partial class Czuwak : Form
    {
        public int sekundy = 10;
        public Czuwak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_czuw.Enabled = false;
            this.Close();

        }

        private void timer_czuw_Tick(object sender, EventArgs e)
        {
            if(sekundy>0)
            {
                sekundy--;
                label2.Text = sekundy.ToString() + " sekund";
            }
            else
            {
                Zalogowany.zalogowany = false;
                timer_czuw.Enabled = false;
                this.Close();
            }
        }
    }
}
