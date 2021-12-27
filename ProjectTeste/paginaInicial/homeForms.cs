using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectTeste
{
    public partial class homeForms : Form
    {
        public homeForms()
        {
            InitializeComponent();
        }

        int cont = 0;

        private void timerHora_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            data.Text = DateTime.Now.ToLongDateString();
        }

        private void catGif_Click(object sender, EventArgs e)
        {
            SecretText.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cont++;
            if (cont == 3)
            {
                catGif.Visible = true;
            }
        }
    }
}
