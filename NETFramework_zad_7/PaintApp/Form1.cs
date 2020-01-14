using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point point1Begin = Point.Empty;
        private Pen pen1;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(639, 313);
            g = Graphics.FromImage(pictureBox1.Image);
            pen1 = new Pen(Color.FromArgb(255, 0, 0, 0));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                point1Begin = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pen1, point1Begin, e.Location);
                point1Begin = e.Location;
                pictureBox1.Refresh();
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pictureBox1.Load(openFileDialog1.FileName);
                g = Graphics.FromImage(pictureBox1.Image);
                this.labelPath.Text = openFileDialog1.FileName;
            }
        }

        private void buttonCzysc_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
            this.labelPath.Text = "";
        }

        private void buttonKolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonKolor.BackColor = colorDialog1.Color;
            pen1.Color = colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen1.Width = float.Parse(this.numericUpDown1.Value.ToString());
            trackBar1.Value = int.Parse(this.numericUpDown1.Value.ToString());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen1.Width = float.Parse(this.trackBar1.Value.ToString());
            numericUpDown1.Value = this.trackBar1.Value;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            pictureBox1.Image.Save(saveFileDialog1.FileName);
        }

        private void buttonDrukuj_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_printPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_printPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
