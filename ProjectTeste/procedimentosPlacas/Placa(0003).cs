using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectTeste
{
    public partial class Placa_0003_ : Form
    {
        // imagens
        Image imgstep0 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FC.jpg");
        Image imgstep1 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCStep1.jpg");
        Image imgstep2 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCStep2.jpg");
        Image imgstep3 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCStep3.jpg");

        //variaveis
        int step = 0;
        bool opcoes = false;


        //componentes valor padrão
        int res10k = 2, res1k = 3, cap1000pf = 1;


        public Placa_0003_()
        {
            InitializeComponent();
        }

        private void Placa_0000__Load(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void setaR_Click(object sender, EventArgs e)
        {
            if(step < 3)
            {
                step++;
            }
            etapa();
        }

        private void setaL_Click(object sender, EventArgs e)
        {
            if(step > 0)
            {
                step--;
            }
            etapa();
        }

        private void etapa()
        {
            textStep.Text = Convert.ToString(step);

            if(step == 0)
            {
                painelGrafico.BackgroundImage = imgstep0;
            }
            else if (step == 1)
            {
                painelGrafico.BackgroundImage = imgstep1;
            }
            else if (step == 2)
            {
                painelGrafico.BackgroundImage = imgstep2;
            }
            else if(step == 3)
            {
                painelGrafico.BackgroundImage = imgstep3;
            }
        }


        private void botaoetapa1_MouseClick(object sender, MouseEventArgs e)
        {
            step = 1;
            etapa();
        }

        private void botaoEtapa2_MouseClick(object sender, MouseEventArgs e)
        {
            step = 2;
            etapa();
        }
        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            step = 3;
            etapa();
        }

        private void Placa_0000__KeyDown(object sender, KeyEventArgs e)
        {
            // seta para esquerda e direita mudam as etapas

            if(e.KeyCode == Keys.Left)
            {
                setaL_Click(null,null);
            }
            else if(e.KeyCode == Keys.Right)
            {
                setaR_Click(null, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // on/off painel de opções

            if(opcoes == false)
            {
                painelOpcoes.Visible = true;
                textBoxQuant.Enabled = true;
                opcoes = true;
            }
            else
            {
                painelOpcoes.Visible = false;
                textBoxQuant.Enabled = false;
                opcoes = false;
            }
        }

 

        private void textBoxQuant_KeyPress(object sender, KeyPressEventArgs e)
        {

            // permite apenas numeros e teclas de ações na caixa de texto

            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8 && number != 13)
            {
                e.Handled = true;
            }
        }


        private void textBoxQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                //muda valores
                resis10ktotal.Text = Convert.ToString(int.Parse(textBoxQuant.Text) * res10k);
                resis1kTotal.Text = Convert.ToString(int.Parse(textBoxQuant.Text) * res1k);
                cap1000pfTotal.Text = Convert.ToString(int.Parse(textBoxQuant.Text) * cap1000pf);
            }
        }


    }
}
