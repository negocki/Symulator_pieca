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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label_fan1.Location = new System.Drawing.Point(305, 72);
            this.label_fan1.Name = "label_fan1";
            this.label_fan1.Size = new System.Drawing.Size(46, 13);
            this.label_fan1.TabIndex = 1;
            this.label_fan1.Text = "Fan 1: 0";
            // 
            // label_fan2
            // 
            this.label_fan2.AutoSize = true;
            this.label_fan2.Location = new System.Drawing.Point(521, 94);
            this.label_fan2.Name = "label_fan2";
            this.label_fan2.Size = new System.Drawing.Size(46, 13);
            this.label_fan2.TabIndex = 2;
            this.label_fan2.Text = "Fan 2: 0";
            // 
            // label_pompazim
            // 
            this.label_pompazim.AutoSize = true;
            this.label_pompazim.Location = new System.Drawing.Point(521, 128);
            this.label_pompazim.Name = "label_pompazim";
            this.label_pompazim.Size = new System.Drawing.Size(73, 13);
            this.label_pompazim.TabIndex = 3;
            this.label_pompazim.Text = "Pompa zimna:";
            // 
            // label_pompaciep
            // 
            this.label_pompaciep.AutoSize = true;
            this.label_pompaciep.Location = new System.Drawing.Point(521, 210);
            this.label_pompaciep.Name = "label_pompaciep";
            this.label_pompaciep.Size = new System.Drawing.Size(76, 13);
            this.label_pompaciep.TabIndex = 4;
            this.label_pompaciep.Text = "Pompa ciepła:";
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
            this.groupBox1.Controls.Add(this.button_ruszt_stop);
            this.groupBox1.Controls.Add(this.button_ruszt_start);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(19, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 81);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 468);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

