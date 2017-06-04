namespace SymulatorPieca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_fan1 = new System.Windows.Forms.Label();
            this.label_fan2 = new System.Windows.Forms.Label();
            this.label_pompazim = new System.Windows.Forms.Label();
            this.label_pompaciep = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_ruszt = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button_ruszt_start = new System.Windows.Forms.Button();
            this.button_ruszt_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar_pompazim = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_awariaruszt = new System.Windows.Forms.Button();
            this.button_awariapomp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button_awaria_went = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_wodazim = new System.Windows.Forms.Label();
            this.label_wodaciep = new System.Windows.Forms.Label();
            this.label_palenisko = new System.Windows.Forms.Label();
            this.timer_symulacja = new System.Windows.Forms.Timer(this.components);
            this.timer_awaria = new System.Windows.Forms.Timer(this.components);
            this.button_rozpal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pompazim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_fan1
            // 
            this.label_fan1.AutoSize = true;
            this.label_fan1.Location = new System.Drawing.Point(210, 182);
            this.label_fan1.Name = "label_fan1";
            this.label_fan1.Size = new System.Drawing.Size(46, 13);
            this.label_fan1.TabIndex = 1;
            this.label_fan1.Text = "Fan 1: 0";
            // 
            // label_fan2
            // 
            this.label_fan2.AutoSize = true;
            this.label_fan2.Location = new System.Drawing.Point(508, 94);
            this.label_fan2.Name = "label_fan2";
            this.label_fan2.Size = new System.Drawing.Size(46, 13);
            this.label_fan2.TabIndex = 2;
            this.label_fan2.Text = "Fan 2: 0";
            // 
            // label_pompazim
            // 
            this.label_pompazim.AutoSize = true;
            this.label_pompazim.Location = new System.Drawing.Point(508, 127);
            this.label_pompazim.Name = "label_pompazim";
            this.label_pompazim.Size = new System.Drawing.Size(109, 13);
            this.label_pompazim.TabIndex = 3;
            this.label_pompazim.Text = "Pompa zimna: 0 RPM";
            // 
            // label_pompaciep
            // 
            this.label_pompaciep.AutoSize = true;
            this.label_pompaciep.Location = new System.Drawing.Point(508, 210);
            this.label_pompaciep.Name = "label_pompaciep";
            this.label_pompaciep.Size = new System.Drawing.Size(112, 13);
            this.label_pompaciep.TabIndex = 4;
            this.label_pompaciep.Text = "Pompa ciepła: 0 RPM";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 24);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 50;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(655, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 277);
            this.listBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Awarie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Podajnik węgla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ruszt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Palenisko";
            // 
            // timer_ruszt
            // 
            this.timer_ruszt.Interval = 1000;
            this.timer_ruszt.Tick += new System.EventHandler(this.timer_ruszt_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_awariaruszt);
            this.groupBox1.Controls.Add(this.button_ruszt_stop);
            this.groupBox1.Controls.Add(this.button_ruszt_start);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(19, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 111);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prędkość rusztu";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Szybko";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Wolno";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button_ruszt_start
            // 
            this.button_ruszt_start.Location = new System.Drawing.Point(98, 17);
            this.button_ruszt_start.Name = "button_ruszt_start";
            this.button_ruszt_start.Size = new System.Drawing.Size(75, 23);
            this.button_ruszt_start.TabIndex = 2;
            this.button_ruszt_start.Text = "Start";
            this.button_ruszt_start.UseVisualStyleBackColor = true;
            this.button_ruszt_start.Click += new System.EventHandler(this.button_ruszt_start_Click);
            // 
            // button_ruszt_stop
            // 
            this.button_ruszt_stop.Location = new System.Drawing.Point(98, 46);
            this.button_ruszt_stop.Name = "button_ruszt_stop";
            this.button_ruszt_stop.Size = new System.Drawing.Size(75, 23);
            this.button_ruszt_stop.TabIndex = 3;
            this.button_ruszt_stop.Text = "Stop";
            this.button_ruszt_stop.UseVisualStyleBackColor = true;
            this.button_ruszt_stop.Click += new System.EventHandler(this.button_ruszt_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_awariapomp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.trackBar_pompazim);
            this.groupBox2.Location = new System.Drawing.Point(213, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 111);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pompy";
            // 
            // trackBar_pompazim
            // 
            this.trackBar_pompazim.LargeChange = 10;
            this.trackBar_pompazim.Location = new System.Drawing.Point(78, 19);
            this.trackBar_pompazim.Name = "trackBar_pompazim";
            this.trackBar_pompazim.Size = new System.Drawing.Size(104, 45);
            this.trackBar_pompazim.SmallChange = 10;
            this.trackBar_pompazim.TabIndex = 0;
            this.trackBar_pompazim.Scroll += new System.EventHandler(this.trackBar_pompazim_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(78, 48);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zimna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciepła";
            // 
            // button_awariaruszt
            // 
            this.button_awariaruszt.Enabled = false;
            this.button_awariaruszt.Location = new System.Drawing.Point(42, 82);
            this.button_awariaruszt.Name = "button_awariaruszt";
            this.button_awariaruszt.Size = new System.Drawing.Size(108, 23);
            this.button_awariaruszt.TabIndex = 4;
            this.button_awariaruszt.Text = "Napraw awarie";
            this.button_awariaruszt.UseVisualStyleBackColor = true;
            // 
            // button_awariapomp
            // 
            this.button_awariapomp.Enabled = false;
            this.button_awariapomp.Location = new System.Drawing.Point(41, 82);
            this.button_awariapomp.Name = "button_awariapomp";
            this.button_awariapomp.Size = new System.Drawing.Size(108, 23);
            this.button_awariapomp.TabIndex = 5;
            this.button_awariapomp.Text = "Napraw awarie";
            this.button_awariapomp.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_awaria_went);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.trackBar3);
            this.groupBox3.Location = new System.Drawing.Point(407, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 82);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wentylator #1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Prędkość";
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(78, 19);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.SmallChange = 10;
            this.trackBar3.TabIndex = 0;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button_awaria_went
            // 
            this.button_awaria_went.Enabled = false;
            this.button_awaria_went.Location = new System.Drawing.Point(39, 51);
            this.button_awaria_went.Name = "button_awaria_went";
            this.button_awaria_went.Size = new System.Drawing.Size(108, 23);
            this.button_awaria_went.TabIndex = 6;
            this.button_awaria_went.Text = "Napraw awarie";
            this.button_awaria_went.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_palenisko);
            this.groupBox4.Controls.Add(this.label_wodaciep);
            this.groupBox4.Controls.Add(this.label_wodazim);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(655, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 82);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametry wyjściowe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Woda - wejście: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Woda - wyjście:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Palenisko - temperatura:";
            // 
            // label_wodazim
            // 
            this.label_wodazim.AutoSize = true;
            this.label_wodazim.Location = new System.Drawing.Point(94, 24);
            this.label_wodazim.Name = "label_wodazim";
            this.label_wodazim.Size = new System.Drawing.Size(23, 13);
            this.label_wodazim.TabIndex = 5;
            this.label_wodazim.Text = "0 C";
            // 
            // label_wodaciep
            // 
            this.label_wodaciep.AutoSize = true;
            this.label_wodaciep.Location = new System.Drawing.Point(94, 37);
            this.label_wodaciep.Name = "label_wodaciep";
            this.label_wodaciep.Size = new System.Drawing.Size(23, 13);
            this.label_wodaciep.TabIndex = 6;
            this.label_wodaciep.Text = "0 C";
            // 
            // label_palenisko
            // 
            this.label_palenisko.AutoSize = true;
            this.label_palenisko.Location = new System.Drawing.Point(133, 56);
            this.label_palenisko.Name = "label_palenisko";
            this.label_palenisko.Size = new System.Drawing.Size(23, 13);
            this.label_palenisko.TabIndex = 7;
            this.label_palenisko.Text = "0 C";
            // 
            // timer_symulacja
            // 
            this.timer_symulacja.Enabled = true;
            this.timer_symulacja.Interval = 1000;
            this.timer_symulacja.Tick += new System.EventHandler(this.timer_symulacja_Tick);
            // 
            // timer_awaria
            // 
            this.timer_awaria.Interval = 10000;
            // 
            // button_rozpal
            // 
            this.button_rozpal.Location = new System.Drawing.Point(407, 409);
            this.button_rozpal.Name = "button_rozpal";
            this.button_rozpal.Size = new System.Drawing.Size(188, 23);
            this.button_rozpal.TabIndex = 15;
            this.button_rozpal.Text = "Rozpal palenisko";
            this.button_rozpal.UseVisualStyleBackColor = true;
            this.button_rozpal.Click += new System.EventHandler(this.button_rozpal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 468);
            this.Controls.Add(this.button_rozpal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_pompaciep);
            this.Controls.Add(this.label_pompazim);
            this.Controls.Add(this.label_fan2);
            this.Controls.Add(this.label_fan1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pompazim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_fan1;
        private System.Windows.Forms.Label label_fan2;
        private System.Windows.Forms.Label label_pompazim;
        private System.Windows.Forms.Label label_pompaciep;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_ruszt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_ruszt_stop;
        private System.Windows.Forms.Button button_ruszt_start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar_pompazim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button_awariaruszt;
        private System.Windows.Forms.Button button_awariapomp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_awaria_went;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_palenisko;
        private System.Windows.Forms.Label label_wodaciep;
        private System.Windows.Forms.Label label_wodazim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer_symulacja;
        private System.Windows.Forms.Timer timer_awaria;
        private System.Windows.Forms.Button button_rozpal;
    }
}

