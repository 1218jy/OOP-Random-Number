using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Random_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random randomnum = new Random();
            randomnum.Next(1, 101);
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {

            // Random randomnum = new Random();
            //randomnum.Next(100);
            // tbt1 = randomnum.ToString();

            Random ranum = new Random();
            int tal = ranum.Next(1, 100);
            tbt1.Text = tal.ToString();


        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void maskedtb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void tbt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
