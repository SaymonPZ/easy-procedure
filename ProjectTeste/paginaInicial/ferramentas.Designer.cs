
namespace easy_procedure
{
    partial class ferramentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ferramentas));
            this.numberToColor = new System.Windows.Forms.PictureBox();
            this.colorToNumber = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberToColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorToNumber)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberToColor
            // 
            this.numberToColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberToColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberToColor.Image = ((System.Drawing.Image)(resources.GetObject("numberToColor.Image")));
            this.numberToColor.Location = new System.Drawing.Point(0, 0);
            this.numberToColor.Margin = new System.Windows.Forms.Padding(20);
            this.numberToColor.Name = "numberToColor";
            this.numberToColor.Size = new System.Drawing.Size(264, 236);
            this.numberToColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberToColor.TabIndex = 1;
            this.numberToColor.TabStop = false;
            // 
            // colorToNumber
            // 
            this.colorToNumber.AccessibleDescription = "Código de cores para valor de resistênsia";
            this.colorToNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.colorToNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorToNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorToNumber.Image = ((System.Drawing.Image)(resources.GetObject("colorToNumber.Image")));
            this.colorToNumber.Location = new System.Drawing.Point(0, 0);
            this.colorToNumber.Margin = new System.Windows.Forms.Padding(20);
            this.colorToNumber.Name = "colorToNumber";
            this.colorToNumber.Size = new System.Drawing.Size(254, 236);
            this.colorToNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorToNumber.TabIndex = 0;
            this.colorToNumber.TabStop = false;
            this.colorToNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorToNumber_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1280, 594);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.colorToNumber);
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 333);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 74);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de código de cores para valor de resistência";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.numberToColor);
            this.panel2.Location = new System.Drawing.Point(314, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 333);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 74);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversor de valor de resistência para código de cores";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1280, 126);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tools/Ferramentas";
            // 
            // ferramentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ferramentas";
            this.Text = "ferramentas";
            ((System.ComponentModel.ISupportInitialize)(this.numberToColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorToNumber)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox numberToColor;
        private System.Windows.Forms.PictureBox colorToNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
    }
}