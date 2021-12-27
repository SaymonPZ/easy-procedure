using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace easy_procedure
{
    public partial class ferramentas : Form
    {
        public ferramentas()
        {
            InitializeComponent();
        }

        //move janela

        private void colorToNumber_MouseClick(object sender, MouseEventArgs e)
        {
            Form fml = new CorParaValor();
            fml.Show();
        }
    }
}
