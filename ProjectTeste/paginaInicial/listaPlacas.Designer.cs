
namespace ProjectTeste
{
    partial class listaPlacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaPlacas));
            this.label1 = new System.Windows.Forms.Label();
            this.textoFiltro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.excluiTexto = new System.Windows.Forms.Label();
            this.bataoPesquisar = new System.Windows.Forms.PictureBox();
            this.tabelaPlacas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bataoPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPlacas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(727, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textoFiltro
            // 
            this.textoFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textoFiltro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoFiltro.Location = new System.Drawing.Point(727, 85);
            this.textoFiltro.Name = "textoFiltro";
            this.textoFiltro.Size = new System.Drawing.Size(190, 27);
            this.textoFiltro.TabIndex = 1;
            this.textoFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textoFiltro_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.excluiTexto);
            this.panel1.Controls.Add(this.bataoPesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textoFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 126);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(197)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placas";
            // 
            // excluiTexto
            // 
            this.excluiTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excluiTexto.AutoSize = true;
            this.excluiTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluiTexto.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.excluiTexto.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.excluiTexto.Location = new System.Drawing.Point(925, 89);
            this.excluiTexto.Name = "excluiTexto";
            this.excluiTexto.Size = new System.Drawing.Size(22, 20);
            this.excluiTexto.TabIndex = 3;
            this.excluiTexto.Text = "X";
            this.excluiTexto.Click += new System.EventHandler(this.excluiTexto_Click);
            // 
            // bataoPesquisar
            // 
            this.bataoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bataoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bataoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bataoPesquisar.Image")));
            this.bataoPesquisar.Location = new System.Drawing.Point(952, 85);
            this.bataoPesquisar.Name = "bataoPesquisar";
            this.bataoPesquisar.Size = new System.Drawing.Size(34, 27);
            this.bataoPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bataoPesquisar.TabIndex = 2;
            this.bataoPesquisar.TabStop = false;
            this.bataoPesquisar.Click += new System.EventHandler(this.bataoPesquisar_Click);
            // 
            // tabelaPlacas
            // 
            this.tabelaPlacas.AllowUserToAddRows = false;
            this.tabelaPlacas.AllowUserToDeleteRows = false;
            this.tabelaPlacas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaPlacas.BackgroundColor = System.Drawing.Color.White;
            this.tabelaPlacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaPlacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabelaPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPlacas.Location = new System.Drawing.Point(12, 142);
            this.tabelaPlacas.MultiSelect = false;
            this.tabelaPlacas.Name = "tabelaPlacas";
            this.tabelaPlacas.ReadOnly = true;
            this.tabelaPlacas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabelaPlacas.RowHeadersVisible = false;
            this.tabelaPlacas.RowHeadersWidth = 51;
            this.tabelaPlacas.RowTemplate.Height = 29;
            this.tabelaPlacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaPlacas.Size = new System.Drawing.Size(974, 415);
            this.tabelaPlacas.TabIndex = 3;
            this.tabelaPlacas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaPlacas_CellDoubleClick);
            // 
            // listaPlacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 569);
            this.Controls.Add(this.tabelaPlacas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaPlacas";
            this.Text = "listaPlacas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bataoPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPlacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bataoPesquisar;
        private System.Windows.Forms.DataGridView tabelaPlacas;
        private System.Windows.Forms.Label excluiTexto;
        private System.Windows.Forms.Label label2;
    }
}