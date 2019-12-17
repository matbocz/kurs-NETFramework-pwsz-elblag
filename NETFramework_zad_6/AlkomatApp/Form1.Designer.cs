namespace AlkomatApp
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
            this.alcoholPictureBox = new System.Windows.Forms.PictureBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.beerLabel = new System.Windows.Forms.Label();
            this.wineLabel = new System.Windows.Forms.Label();
            this.vodkaLabel = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.beerTextBox = new System.Windows.Forms.TextBox();
            this.wineTextBox = new System.Windows.Forms.TextBox();
            this.vodkaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kRadioButton = new System.Windows.Forms.RadioButton();
            this.mRadioButton = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alcoholPictureBox
            // 
            this.alcoholPictureBox.Image = global::AlkomatApp.Properties.Resources.alkohol;
            this.alcoholPictureBox.InitialImage = null;
            this.alcoholPictureBox.Location = new System.Drawing.Point(-1, -8);
            this.alcoholPictureBox.Name = "alcoholPictureBox";
            this.alcoholPictureBox.Size = new System.Drawing.Size(324, 468);
            this.alcoholPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alcoholPictureBox.TabIndex = 0;
            this.alcoholPictureBox.TabStop = false;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(329, 45);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(104, 17);
            this.bodyLabel.TabIndex = 1;
            this.bodyLabel.Text = "Body mass [kg]";
            // 
            // beerLabel
            // 
            this.beerLabel.AutoSize = true;
            this.beerLabel.Location = new System.Drawing.Point(329, 153);
            this.beerLabel.Name = "beerLabel";
            this.beerLabel.Size = new System.Drawing.Size(92, 17);
            this.beerLabel.TabIndex = 2;
            this.beerLabel.Text = "Beer [250 ml]";
            // 
            // wineLabel
            // 
            this.wineLabel.AutoSize = true;
            this.wineLabel.Location = new System.Drawing.Point(329, 195);
            this.wineLabel.Name = "wineLabel";
            this.wineLabel.Size = new System.Drawing.Size(94, 17);
            this.wineLabel.TabIndex = 3;
            this.wineLabel.Text = "Wine [100 ml]";
            // 
            // vodkaLabel
            // 
            this.vodkaLabel.AutoSize = true;
            this.vodkaLabel.Location = new System.Drawing.Point(329, 239);
            this.vodkaLabel.Name = "vodkaLabel";
            this.vodkaLabel.Size = new System.Drawing.Size(94, 17);
            this.vodkaLabel.TabIndex = 4;
            this.vodkaLabel.Text = "Vodka [50 ml]";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(440, 45);
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(79, 22);
            this.bodyTextBox.TabIndex = 5;
            this.bodyTextBox.Text = "0";
            // 
            // beerTextBox
            // 
            this.beerTextBox.Location = new System.Drawing.Point(440, 148);
            this.beerTextBox.Name = "beerTextBox";
            this.beerTextBox.Size = new System.Drawing.Size(79, 22);
            this.beerTextBox.TabIndex = 6;
            this.beerTextBox.Text = "0";
            // 
            // wineTextBox
            // 
            this.wineTextBox.Location = new System.Drawing.Point(440, 192);
            this.wineTextBox.Name = "wineTextBox";
            this.wineTextBox.Size = new System.Drawing.Size(79, 22);
            this.wineTextBox.TabIndex = 7;
            this.wineTextBox.Text = "0";
            // 
            // vodkaTextBox
            // 
            this.vodkaTextBox.Location = new System.Drawing.Point(440, 239);
            this.vodkaTextBox.Name = "vodkaTextBox";
            this.vodkaTextBox.Size = new System.Drawing.Size(79, 22);
            this.vodkaTextBox.TabIndex = 8;
            this.vodkaTextBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kRadioButton);
            this.groupBox1.Controls.Add(this.mRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(332, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // kRadioButton
            // 
            this.kRadioButton.AutoSize = true;
            this.kRadioButton.Location = new System.Drawing.Point(108, 22);
            this.kRadioButton.Name = "kRadioButton";
            this.kRadioButton.Size = new System.Drawing.Size(38, 21);
            this.kRadioButton.TabIndex = 1;
            this.kRadioButton.TabStop = true;
            this.kRadioButton.Text = "K";
            this.kRadioButton.UseVisualStyleBackColor = true;
            // 
            // mRadioButton
            // 
            this.mRadioButton.AutoSize = true;
            this.mRadioButton.Checked = true;
            this.mRadioButton.Location = new System.Drawing.Point(49, 22);
            this.mRadioButton.Name = "mRadioButton";
            this.mRadioButton.Size = new System.Drawing.Size(40, 21);
            this.mRadioButton.TabIndex = 0;
            this.mRadioButton.TabStop = true;
            this.mRadioButton.Text = "M";
            this.mRadioButton.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(332, 294);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(187, 47);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vodkaTextBox);
            this.Controls.Add(this.wineTextBox);
            this.Controls.Add(this.beerTextBox);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.vodkaLabel);
            this.Controls.Add(this.wineLabel);
            this.Controls.Add(this.beerLabel);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.alcoholPictureBox);
            this.Name = "Form1";
            this.Text = "Alcohol Tester";
            ((System.ComponentModel.ISupportInitialize)(this.alcoholPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alcoholPictureBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label beerLabel;
        private System.Windows.Forms.Label wineLabel;
        private System.Windows.Forms.Label vodkaLabel;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.TextBox beerTextBox;
        private System.Windows.Forms.TextBox wineTextBox;
        private System.Windows.Forms.TextBox vodkaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kRadioButton;
        private System.Windows.Forms.RadioButton mRadioButton;
        private System.Windows.Forms.Button calcButton;
    }
}

