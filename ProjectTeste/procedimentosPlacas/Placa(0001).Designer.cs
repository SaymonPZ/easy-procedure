
namespace ProjectTeste
{
    partial class Placa_0001_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placa_0001_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.setaR = new System.Windows.Forms.PictureBox();
            this.setaL = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setaL)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 673);
            this.panel1.TabIndex = 0;
            // 
            // setaR
            // 
            this.setaR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.setaR.Image = ((System.Drawing.Image)(resources.GetObject("setaR.Image")));
            this.setaR.Location = new System.Drawing.Point(870, 597);
            this.setaR.Name = "setaR";
            this.setaR.Size = new System.Drawing.Size(78, 64);
            this.setaR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setaR.TabIndex = 1;
            this.setaR.TabStop = false;
            // 
            // setaL
            // 
            this.setaL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.setaL.Image = ((System.Drawing.Image)(resources.GetObject("setaL.Image")));
            this.setaL.Location = new System.Drawing.Point(664, 597);
            this.setaL.Name = "setaL";
            this.setaL.Size = new System.Drawing.Size(78, 64);
            this.setaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setaL.TabIndex = 2;
            this.setaL.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(743, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passo / Step:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.textStep);
            this.panel2.Location = new System.Drawing.Point(750, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 40);
            this.panel2.TabIndex = 3;
            // 
            // textStep
            // 
            this.textStep.BackColor = System.Drawing.Color.Transparent;
            this.textStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textStep.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textStep.ForeColor = System.Drawing.SystemColors.Menu;
            this.textStep.Location = new System.Drawing.Point(0, 0);
            this.textStep.Name = "textStep";
            this.textStep.Size = new System.Drawing.Size(116, 40);
            this.textStep.TabIndex = 0;
            this.textStep.Text = "0";
            this.textStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Placa_0000_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setaL);
            this.Controls.Add(this.setaR);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 420);
            this.Name = "Placa_0000_";
            this.Text = "Placa_0000_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Placa_0000__Load);
            ((System.ComponentModel.ISupportInitialize)(this.setaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setaL)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox setaR;
        private System.Windows.Forms.PictureBox setaL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label textStep;
    }
}