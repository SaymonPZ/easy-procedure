using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Linq;

namespace easy_procedure
{
    public partial class Suporte : Form
    {
        public Suporte()
        {
            InitializeComponent();
        }



        private void enviarEmail()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using(MailMessage email = new MailMessage())
                    {

                        //config 

                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("suporteeasypro@gmail.com", "suporte5546");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;


                        // destinatario e remetente
                        email.From = new MailAddress("suporteeasypro@gmail.com");
                        email.To.Add("suporteeasypro@gmail.com");

                        // menssagem
                        email.Subject = textName.Text;
                        email.IsBodyHtml = false;
                        email.Body = textMensagem.Text;

                        //anexo
                        if(caminhoAnexo.Text != "")
                        {
                            //recebe e trata o nome/caminho dos arquivos
                            var arquivoAnexo = caminhoAnexo.Text.ToString().Split(";");

                            //envia todos os arquivos
                            for (int c = 0; c < arquivoAnexo.Count(); c++)
                                email.Attachments.Add(new Attachment(arquivoAnexo[c]));
                        }

                        smtp.Send(email);
                    }
                    MessageBox.Show("Menssagem enviada. Obrigado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo de errado ocorreu. Verefique sua conexão ou entre em contato com o serviço técnico por outro método. Erro: " + ex.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviarEmail();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var arquivoAnexo = new OpenFileDialog();
            arquivoAnexo.Multiselect = true;
            arquivoAnexo.Title = "Anexar arquivos";


            if(arquivoAnexo.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < arquivoAnexo.FileNames.Count(); i++)
                {

                    //adiciona o nome de cada arquivo e os separas com (;)
                    if (i == 0)
                    {
                        caminhoAnexo.Text = arquivoAnexo.FileNames[i];
                    }
                    else
                    {
                        caminhoAnexo.Text = caminhoAnexo.Text + ";" + arquivoAnexo.FileNames[i];
                    }
                }
            }
        }
    }

}
