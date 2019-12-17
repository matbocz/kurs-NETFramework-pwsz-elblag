using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlkomatApp
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        public FormInfo(string b, string w, string v, double r, int i)
        {
            InitializeComponent();

            this.beerLabel.Text += b;
            this.wineLabel.Text += w;
            this.vodkaLabel.Text += v;
            this.resultLabel.Text += Convert.ToString(Math.Round(r, 2));

            string x = "images\\" + i.ToString() + ".jpg";
            this.alcoholPictureBox.Load(x);
        }
    }
}
