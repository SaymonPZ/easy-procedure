
namespace ProjectTeste
{
    partial class homeForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SecretText = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.textLogo = new System.Windows.Forms.Label();
            this.catGif = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.SecretText);
            this.panel1.Controls.Add(this.data);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.textLogo);
            this.panel1.Controls.Add(this.catGif);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 545);
            this.panel1.TabIndex = 1;
            // 
            // SecretText
            // 
            this.SecretText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretText.AutoSize = true;
            this.SecretText.BackColor = System.Drawing.Color.Transparent;
            this.SecretText.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecretText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SecretText.Location = new System.Drawing.Point(854, 402);
            this.SecretText.Name = "SecretText";
            this.SecretText.Size = new System.Drawing.Size(114, 32);
            this.SecretText.TabIndex = 5;
            this.SecretText.Text = "Só mais 25 \r\nminutinho rsrs";
            this.SecretText.Visible = false;
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.data.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.data.Location = new System.Drawing.Point(991, 516);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(45, 20);
            this.data.TabIndex = 3;
            this.data.Text = "data";
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hora
            // 
            this.hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hora.Location = new System.Drawing.Point(962, 487);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(74, 20);
            this.hora.TabIndex = 2;
            this.hora.Text = "tempo";
            this.hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLogo
            // 
            this.textLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLogo.AutoSize = true;
            this.textLogo.BackColor = System.Drawing.Color.Transparent;
            this.textLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLogo.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textLogo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textLogo.Location = new System.Drawing.Point(494, 189);
            this.textLogo.Name = "textLogo";
            this.textLogo.Size = new System.Drawing.Size(443, 196);
            this.textLogo.TabIndex = 1;
            this.textLogo.Text = "Tomorrow\'s \r\ninnovation";
            this.textLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // catGif
            // 
            this.catGif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.catGif.BackColor = System.Drawing.Color.Transparent;
            this.catGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.catGif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catGif.Image = ((System.Drawing.Image)(resources.GetObject("catGif.Image")));
            this.catGif.Location = new System.Drawing.Point(937, 402);
            this.catGif.Name = "catGif";
            this.catGif.Size = new System.Drawing.Size(108, 111);
            this.catGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catGif.TabIndex = 4;
            this.catGif.TabStop = false;
            this.catGif.Visible = false;
            this.catGif.Click += new System.EventHandler(this.catGif_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // homeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1048, 545);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeForms";
            this.Text = "homeForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textLogo;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.PictureBox catGif;
        private System.Windows.Forms.Label SecretText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}