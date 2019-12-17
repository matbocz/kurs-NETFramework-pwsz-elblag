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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double resultX, A, K = 0.7;

            A = 20.0 * Convert.ToInt16(beerTextBox.Text)
                + 10 * Convert.ToInt16(wineTextBox.Text)
                + 16.6 * Convert.ToInt16(vodkaTextBox.Text);

            if (kRadioButton.Checked == true) { K = 0.6; }

            resultX = A / (K * Convert.ToInt16(bodyTextBox.Text));

            int resultInfo = 0;

            if (resultX <= 0.2) resultInfo = 0;
            else if (resultX <= 0.5) resultInfo = 1;
            else if (resultX <= 2.5) resultInfo = 2;
            else if (resultX < 5) resultInfo = 3;
            else resultInfo = 4;

            FormInfo f = new FormInfo(this.beerTextBox.Text, this.wineTextBox.Text, this.vodkaTextBox.Text, resultX, resultInfo);
            f.Show();
        }
    }
}
