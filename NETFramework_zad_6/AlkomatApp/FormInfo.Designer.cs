namespace AlkomatApp
{
    partial class FormInfo
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
            this.beerLabel = new System.Windows.Forms.Label();
            this.wineLabel = new System.Windows.Forms.Label();
            this.vodkaLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.saveLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.alcoholPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // alcoholPictureBox
            // 
            this.alcoholPictureBox.Location = new System.Drawing.Point(1, -8);
            this.alcoholPictureBox.Name = "alcoholPictureBox";
            this.alcoholPictureBox.Size = new System.Drawing.Size(365, 346);
            this.alcoholPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alcoholPictureBox.TabIndex = 0;
            this.alcoholPictureBox.TabStop = false;
            // 
            // beerLabel
            // 
            this.beerLabel.AutoSize = true;
            this.beerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beerLabel.Location = new System.Drawing.Point(372, 50);
            this.beerLabel.Name = "beerLabel";
            this.beerLabel.Size = new System.Drawing.Size(77, 29);
            this.beerLabel.TabIndex = 1;
            this.beerLabel.Text = "Beer: ";
            // 
            // wineLabel
            // 
            this.wineLabel.AutoSize = true;
            this.wineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wineLabel.Location = new System.Drawing.Point(372, 97);
            this.wineLabel.Name = "wineLabel";
            this.wineLabel.Size = new System.Drawing.Size(80, 29);
            this.wineLabel.TabIndex = 2;
            this.wineLabel.Text = "Wine: ";
            // 
            // vodkaLabel
            // 
            this.vodkaLabel.AutoSize = true;
            this.vodkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vodkaLabel.Location = new System.Drawing.Point(372, 142);
            this.vodkaLabel.Name = "vodkaLabel";
            this.vodkaLabel.Size = new System.Drawing.Size(93, 29);
            this.vodkaLabel.TabIndex = 3;
            this.vodkaLabel.Text = "Vodka: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(372, 309);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(93, 29);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result: ";
            // 
            // saveLinkLabel
            // 
            this.saveLinkLabel.AutoSize = true;
            this.saveLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveLinkLabel.Location = new System.Drawing.Point(109, 380);
            this.saveLinkLabel.Name = "saveLinkLabel";
            this.saveLinkLabel.Size = new System.Drawing.Size(148, 31);
            this.saveLinkLabel.TabIndex = 5;
            this.saveLinkLabel.TabStop = true;
            this.saveLinkLabel.Text = "Save to file";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.saveLinkLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.vodkaLabel);
            this.Controls.Add(this.wineLabel);
            this.Controls.Add(this.beerLabel);
            this.Controls.Add(this.alcoholPictureBox);
            this.Name = "FormInfo";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.alcoholPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alcoholPictureBox;
        private System.Windows.Forms.Label beerLabel;
        private System.Windows.Forms.Label wineLabel;
        private System.Windows.Forms.Label vodkaLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.LinkLabel saveLinkLabel;
    }
}