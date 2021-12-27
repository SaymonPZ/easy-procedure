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
    public partial class CorParaValor : Form
    {
        public CorParaValor()
        {
            InitializeComponent();
        }

        int banda1 = 0, banda2 = 0, banda3 = 0, banda4 = 0, banda5 = 0, selecao;
        int cor, modo = 0;
        float divisão, resultado;
        string tolerancia, stringResultado;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);


        private void preto_MouseClick(object sender, MouseEventArgs e)
        {
            preto.Checked = true;

            marrom.Checked = false;
            vermelho.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 0;
            setCor(cor);
        }

        private void marrom_MouseClick(object sender, MouseEventArgs e)
        {
            marrom.Checked = true;

            preto.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 1;
            setCor(cor);
        }

        private void vermelho_MouseClick(object sender, MouseEventArgs e)
        {
            vermelho.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 2;
            setCor(cor);
        }

        private void laranja_MouseClick(object sender, MouseEventArgs e)
        {
            laranja.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 3;
            setCor(cor);
        }

        private void amarelo_MouseClick(object sender, MouseEventArgs e)
        {
            amarelo.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 4;
            setCor(cor);
        }

        private void verde_MouseClick(object sender, MouseEventArgs e)
        {
            verde.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 5;
            setCor(cor);
        }

        private void azul_MouseClick(object sender, MouseEventArgs e)
        {
            azul.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 6;
            setCor(cor);
        }

        private void violeta_MouseClick(object sender, MouseEventArgs e)
        {
            violeta.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 7;
            setCor(cor);
        }

        private void cinza_MouseClick(object sender, MouseEventArgs e)
        {
            cinza.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 8;
            setCor(cor);
        }

        private void branco_MouseClick(object sender, MouseEventArgs e)
        {
            branco.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            dourado.Checked = false;
            prata.Checked = false;

            cor = 9;
            setCor(cor);
        }

        private void dourado_MouseClick(object sender, MouseEventArgs e)
        {
            dourado.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            prata.Checked = false;

            cor = 10;
            setCor(cor);
        }

        private void prata_MouseClick(object sender, MouseEventArgs e)
        {
            prata.Checked = true;

            preto.Checked = false;
            marrom.Checked = false;
            vermelho.Checked = false;
            vermelho.Checked = false;
            laranja.Checked = false;
            amarelo.Checked = false;
            verde.Checked = false;
            azul.Checked = false;
            violeta.Checked = false;
            cinza.Checked = false;
            branco.Checked = false;
            dourado.Checked = false;

            cor = 11;
            setCor(cor);
        }


        private void setCor(int setCor)
        {
            if (selecao == 1)
            {
                banda1 = setCor;

                if (setCor == 0)
                {
                    faixa1.BackColor = Color.Black;
                } 
                else if (setCor == 1)
                {
                    faixa1.BackColor = Color.Brown;
                }
                else if (setCor == 2)
                {
                    faixa1.BackColor = Color.Red;
                }
                else if (setCor == 3)
                {
                    faixa1.BackColor = Color.Orange;
                }
                else if (setCor == 4)
                {
                    faixa1.BackColor = Color.Yellow;
                }
                else if (setCor == 5)
                {
                    faixa1.BackColor = Color.Green;
                }
                else if (setCor == 6)
                {
                    faixa1.BackColor = Color.Blue;
                }
                else if (setCor == 7)
                {
                    faixa1.BackColor = Color.Purple;
                }
                else if (setCor == 8)
                {
                    faixa1.BackColor = Color.Gray;
                }
                else if (setCor == 9)
                {
                    faixa1.BackColor = Color.White;
                }

            }
            else if (selecao == 2)
            {
                banda2 = setCor;

                if (setCor == 0)
                {
                    faixa2.BackColor = Color.Black;
                }
                else if (setCor == 1)
                {
                    faixa2.BackColor = Color.Brown;
                }
                else if (setCor == 2)
                {
                    faixa2.BackColor = Color.Red;
                }
                else if (setCor == 3)
                {
                    faixa2.BackColor = Color.Orange;
                }
                else if (setCor == 4)
                {
                    faixa2.BackColor = Color.Yellow;
                }
                else if (setCor == 5)
                {
                    faixa2.BackColor = Color.Green;
                }
                else if (setCor == 6)
                {
                    faixa2.BackColor = Color.Blue;
                }
                else if (setCor == 7)
                {
                    faixa2.BackColor = Color.Purple;
                }
                else if (setCor == 8)
                {
                    faixa2.BackColor = Color.Gray;
                }
                else if (setCor == 9)
                {
                    faixa2.BackColor = Color.White;
                }
            }
            else if (selecao == 3)
            {
                banda3 = setCor;

                if (setCor == 0)
                {
                    faixa3.BackColor = Color.Black;
                }
                else if (setCor == 1)
                {
                    faixa3.BackColor = Color.Brown;
                }
                else if (setCor == 2)
                {
                    faixa3.BackColor = Color.Red;
                }
                else if (setCor == 3)
                {
                    faixa3.BackColor = Color.Orange;
                }
                else if (setCor == 4)
                {
                    faixa3.BackColor = Color.Yellow;
                }
                else if (setCor == 5)
                {
                    faixa3.BackColor = Color.Green;
                }
                else if (setCor == 6)
                {
                    faixa3.BackColor = Color.Blue;
                }
                else if (setCor == 7)
                {
                    faixa3.BackColor = Color.Purple;
                }
                else if (setCor == 8)
                {
                    faixa3.BackColor = Color.Gray;
                }
                else if (setCor == 9)
                {
                    faixa3.BackColor = Color.White;
                }
            }
            else if (selecao == 4)
            {
                banda4 = setCor;

                if (setCor == 0)
                {
                    faixa4.BackColor = Color.Black;
                }
                else if (setCor == 1)
                {
                    faixa4.BackColor = Color.Brown;
                }
                else if (setCor == 2)
                {
                    faixa4.BackColor = Color.Red;
                }
                else if (setCor == 3)
                {
                    faixa4.BackColor = Color.Orange;
                }
                else if (setCor == 4)
                {
                    faixa4.BackColor = Color.Yellow;
                }
                else if (setCor == 5)
                {
                    faixa4.BackColor = Color.Green;
                }
                else if (setCor == 6)
                {
                    faixa4.BackColor = Color.Blue;
                }
                else if (setCor == 7)
                {
                    faixa4.BackColor = Color.Purple;
                }
                else if (setCor == 8)
                {
                    faixa4.BackColor = Color.Gray;
                }
                else if (setCor == 9)
                {
                    faixa4.BackColor = Color.White;
                }
            }
            else if (selecao == 5)
            {
                banda5 = setCor;

                if (setCor == 0)
                {
                    faixa5.BackColor = Color.Black;
                }
                else if (setCor == 1)
                {
                    faixa5.BackColor = Color.Brown;
                    tolerancia = "1%";
                }
                else if (setCor == 2)
                {
                    faixa5.BackColor = Color.Red;
                    tolerancia = "2%";
                }
                else if (setCor == 3)
                {
                    faixa5.BackColor = Color.Orange;
                }
                else if (setCor == 4)
                {
                    faixa5.BackColor = Color.Yellow;
                }
                else if (setCor == 5)
                {
                    faixa5.BackColor = Color.Green;
                    tolerancia = "0,5%";
                }
                else if (setCor == 6)
                {
                    faixa5.BackColor = Color.Blue;
                    tolerancia = "0,25%";
                }
                else if (setCor == 7)
                {
                    faixa5.BackColor = Color.Purple;
                    tolerancia = "0,1%";
                }
                else if (setCor == 8)
                {
                    faixa5.BackColor = Color.Gray;
                    tolerancia = "0,05%";
                }
                else if (setCor == 9)
                {
                    faixa5.BackColor = Color.White;
                }
                else if (setCor == 10)
                {
                    faixa5.BackColor = Color.Gold;
                    tolerancia = "5%";
                }
                else if (setCor == 11)
                {
                    faixa5.BackColor = Color.Silver;
                    tolerancia = "10%";
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void minimizateButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(modo == 0)
            {
                modo = 1;
                buttonmodo.Text = ("Mudar para modo 4 faixas");
                faixa4.Visible = true;
            }
            else
            {
                modo = 0;
                buttonmodo.Text = ("Mudar para modo 5 faixas");
                faixa4.Visible = false;
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void faixa1_MouseClick(object sender, MouseEventArgs e)
        {
            textoselecao.Text = "Faixa/Banda 1";
            painelColor.Enabled = true;
            selecao = 1;
        }
        private void faixa2_MouseClick(object sender, MouseEventArgs e)
        {
            textoselecao.Text = "Faixa/Banda 2";
            painelColor.Enabled = true;
            selecao = 2;
        }
        private void faixa3_MouseClick(object sender, MouseEventArgs e)
        {
            textoselecao.Text = "Faixa/Banda 3";
            painelColor.Enabled = true;
            selecao = 3;
        }
        private void faixa4_MouseClick(object sender, MouseEventArgs e)
        {
            textoselecao.Text = "Faixa/Banda 4";
            painelColor.Enabled = true;
            selecao = 4;
        }
        private void faixa5_MouseClick(object sender, MouseEventArgs e)
        {
            textoselecao.Text = "Faixa/Banda 5";
            painelColor.Enabled = true;
            selecao = 5;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if(modo == 0)
            {
                resultado = ((banda1 * 10) + (banda2)) * Convert.ToInt32((Math.Pow (10, banda3)));

                //MessageBox.Show(Convert.ToString(restoPorMil));
                if(resultado >= 1000 && resultado < 1000000)
                {
                    divisão = resultado / 1000;
                    stringResultado = Convert.ToString(divisão) + "kΩ " + tolerancia;
                    textResultado.Text = stringResultado;
                }
                else if(resultado < 1000)
                {
                    stringResultado = Convert.ToString(resultado) + "Ω " + tolerancia;
                    textResultado.Text = stringResultado;
                }
                else if (resultado >= 1000000)
                {
                    divisão = resultado / 1000000;
                    stringResultado = Convert.ToString(divisão) + "kkΩ " + tolerancia;
                    textResultado.Text = stringResultado;
                }


            }

            //textResultado.Text = (Convert.ToString(resultado));
        }
    }
}
