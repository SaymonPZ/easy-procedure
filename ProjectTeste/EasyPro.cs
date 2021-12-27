using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using easy_procedure;

namespace ProjectTeste
{
    public partial class EasyPro : Form
    {
        int menuRetraido = 85;
        private Form janelaCentral;

        public EasyPro()
        {
            InitializeComponent();
            this.Text = "Easy Pro.";
            MenuLateral.Width = menuRetraido;
            buttonHome_Click(null, null);
        }


        //move janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        //abrir conteudo no painelCentral

        private void openForm(Form formPainel)
        {
            //abrir apenas uma
            if(janelaCentral != null)
            {
                janelaCentral.Close();
                janelaCentral.Dispose();
            }
            janelaCentral = formPainel;
            janelaCentral.TopLevel = false;
            janelaCentral.FormBorderStyle = FormBorderStyle.None;
            janelaCentral.Dock = DockStyle.Fill;
            painelCentral.Controls.Add(janelaCentral);
            painelCentral.Tag = janelaCentral;
            janelaCentral.BringToFront();
            janelaCentral.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuLateral.Width == 250)
            {
                MenuLateral.Width = menuRetraido;
            }
            else
            {
                MenuLateral.Width = 250;
            }
        }

        private void painelCima_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void screenButton_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizateButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            openForm(new homeForms());
        }

        private void buttonPlacas_Click(object sender, EventArgs e)
        {
            openForm(new listaPlacas());
        }
        private void buttonCabos_Click(object sender, EventArgs e)
        {
            openForm(new listaCabos());
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            openForm(new listaProdutos());
        }

        private void buttonTools_Click_1(object sender, EventArgs e)
        {
            openForm(new ferramentas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Suporte());
        }
    }
}
