namespace PaintApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonCzysc = new System.Windows.Forms.Button();
            this.buttonKolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonDrukuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(13, 13);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(0, 17);
            this.labelPath.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(657, 33);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(131, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Otwórz";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(657, 63);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(131, 23);
            this.buttonZapisz.TabIndex = 3;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonCzysc
            // 
            this.buttonCzysc.Location = new System.Drawing.Point(657, 133);
            this.buttonCzysc.Name = "buttonCzysc";
            this.buttonCzysc.Size = new System.Drawing.Size(131, 23);
            this.buttonCzysc.TabIndex = 4;
            this.buttonCzysc.Text = "Czyść";
            this.buttonCzysc.UseVisualStyleBackColor = true;
            this.buttonCzysc.Click += new System.EventHandler(this.buttonCzysc_Click);
            // 
            // buttonKolor
            // 
            this.buttonKolor.Location = new System.Drawing.Point(657, 322);
            this.buttonKolor.Name = "buttonKolor";
            this.buttonKolor.Size = new System.Drawing.Size(131, 23);
            this.buttonKolor.TabIndex = 5;
            this.buttonKolor.Text = "Kolor";
            this.buttonKolor.UseVisualStyleBackColor = true;
            this.buttonKolor.Click += new System.EventHandler(this.buttonKolor_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(657, 352);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 353);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(639, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonDrukuj
            // 
            this.buttonDrukuj.Location = new System.Drawing.Point(658, 163);
            this.buttonDrukuj.Name = "buttonDrukuj";
            this.buttonDrukuj.Size = new System.Drawing.Size(130, 23);
            this.buttonDrukuj.TabIndex = 8;
            this.buttonDrukuj.Text = "Drukuj";
            this.buttonDrukuj.UseVisualStyleBackColor = true;
            this.buttonDrukuj.Click += new System.EventHandler(this.buttonDrukuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDrukuj);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonKolor);
            this.Controls.Add(this.buttonCzysc);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonCzysc;
        private System.Windows.Forms.Button buttonKolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonDrukuj;
    }
}

