using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectTeste
{
    public partial class listaProdutos : Form
    {
        DataTable dt = new DataTable();
        String cod;

        public listaProdutos()
        {
            InitializeComponent();
            carregarTabela();
            configurarLista();
        }

        private void carregarTabela()
        {
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Revisão", typeof(string));

            //adicionar itens código e produto
            dt.Rows.Add(new object[] {"0000", "Produto teste", "19/09/2021"});


            tabelaPlacas.DataSource = dt;
        }
        private void configurarLista()
        {

            tabelaPlacas.Columns["Código"].Width = 65;
            tabelaPlacas.Columns["Código"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPlacas.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabelaPlacas.Columns["Produto"].Width = 1000; // tamanho da coluna

            tabelaPlacas.Columns["Revisão"].Width = 100; // tamanho da coluna

        }

        private void filtro()
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Código", textoFiltro.Text);
            tabelaPlacas.DataSource = dt;
        }

        private void bataoPesquisar_Click(object sender, EventArgs e)
        {
            filtro();
        }

        private void excluiTexto_Click(object sender, EventArgs e)
        {
            textoFiltro.Text = "";
            filtro();
        }

        private void tabelaPlacas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = this.tabelaPlacas.CurrentRow.Cells[0].Value.ToString();

            //abre a placa selecionada

            if (cod == "0000")
            {
                //Placa_0000_ formplaca = new Placa_0000_();
                //formplaca.Show();
            }
            else if(cod == "0001")
            {
            }
        }

        private void textoFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                filtro();
            }
        }
    }
}
