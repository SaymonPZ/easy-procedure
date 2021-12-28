using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectTeste
{
    public partial class Placa_0000_ : Form
    { 
        Image imgstep0;
        Image imgstep1;
        Image imgstep2;
        Image imgstep3;
        Image imgstep4;

        Image imgRes10k5p;
        Image imgRes1k5p;
        Image imgCapEletro1000u50v;

        //variaveis
        int step = 0;
        bool opcoes = false;
        int numeroDePassos = 4;


        //componentes valor padrão
        int res10k = 2, res1k = 3, cap1000pf = 1;


        public Placa_0000_()
        {
            InitializeComponent();
            painelDescricao.Height = 29;
            painelFundo.TabStop = false;
            carregarImagens();
        }


        // Funções
        private void carregarImagens()
        {
            try
            {
                // imagens das etapas
                imgstep0 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FC.jpg");
                imgstep1 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCStep1.jpg");
                imgstep2 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCStep2.jpg");
                imgstep3 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCStep3.jpg");
                imgstep4 = Image.FromFile(@"C:\EasyProFiles\placaTeste0000\FFRSKBCJ0MOQ4FCFinal.jpg");

                //imagens das descrições

                imgRes10k5p = Image.FromFile(@"C:\EasyProFiles\Componentes\Resistores\10k5%.jpg");
                imgRes1k5p = Image.FromFile(@"C:\EasyProFiles\Componentes\Resistores\1k5%.jpg");
                imgCapEletro1000u50v = Image.FromFile(@"C:\EasyProFiles\Componentes\CapEletro\1000uf50V.jpg");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo de errado ocorreu, ferifique a integridade dos arquivos. Erro: " + erro);
            }
        }
        private void etapa()
        {
            textStep.Text = Convert.ToString(step);

            if(step == 0)
            {
                painelGrafico.BackgroundImage = imgstep0;
                imagemDescricao.Image = (null);
                textoDescricao.Text = ("Nenhuma Descrição disponível.");
                textoLabel.Text = ("");
            }
            else if (step == 1)
            {
                painelGrafico.BackgroundImage = imgstep1;
                imagemDescricao.Image = imgRes10k5p;
                textoDescricao.Text = ("Resistor 10k 5% \n\nLabels: R1 e R2.\n\nOrdem de cores para 4 faixas: Marrom, preto, laranja e dourado.");
                textoLabel.Text = ("Resistor 10k 5%");
            }
            else if (step == 2)
            {
                painelGrafico.BackgroundImage = imgstep2;
                imagemDescricao.Image = imgRes1k5p;
                textoDescricao.Text = ("Resistor 1k 5% \n\nLabels: R3, R5 e R9.\n\nOrdem de cores para 4 faixas: Marrom, preto, vermelho e dourado.");
                textoLabel.Text = ("Resistor 1k 5%");
            }
            else if(step == 3)
            {
                painelGrafico.BackgroundImage = imgstep3;
                imagemDescricao.Image = imgCapEletro1000u50v;
                textoDescricao.Text = ("Capacitor Eletrolidico 1000uf - 50v\n\nLabel: C1\n\nA faixa branca representa a polaridade negativa.");
                textoLabel.Text = ("Capacitor Eletrolidico 1000uf - 50v");
            }
            else if (step == 4)
            {
                painelGrafico.BackgroundImage = imgstep4;
                imagemDescricao.Image = null;
                textoDescricao.Text = ("Encaminhe ao Controle de qualidade.");
                textoLabel.Text = ("Finalização");
            }
        }

        // Paineis adicionais
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
        private void botaoDescricao_MouseClick(object sender, MouseEventArgs e)
        {
            painelGrafico.Focus();
            if (painelDescricao.Height == 29)
            {
                painelDescricao.Height = 378;
            }
            else
            {
                painelDescricao.Height = 29;
            }
        }

        // botões passos
        private void botaoPasso1_MouseClick(object sender, MouseEventArgs e)
        {
            step = 1;
            etapa();
        }
        private void botaoPasso2_MouseClick(object sender, MouseEventArgs e)
        {
            step = 2;
            etapa();
        }
        private void botaoPasso3_MouseClick(object sender, MouseEventArgs e)
        {
            step = 3;
            etapa();
        }
        private void botaoPasso4_MouseClick(object sender, MouseEventArgs e)
        {
            step = 4;
            etapa();
        }

        // Setas
        private void setaR_Click(object sender, EventArgs e)
        {
            if(step < numeroDePassos)
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

        // Funções do teclado
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
    }
}
