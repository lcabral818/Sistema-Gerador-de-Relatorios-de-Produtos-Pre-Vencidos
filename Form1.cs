using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gerador_de_Relatorios_de_Produtos_Pre_Vencidos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Cadastrar_Produto_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos
            {
                NomeDoProduto = txtb_Nome_Produto.Text,
                CodigoDoProduto = txtb_Cod_Produto.Text,
                Lote = txtb_Lote.Text,
                Quantidade = txtb_Quantidade.Text,
                Validade = txtb_Validade.Text,
                PreVencimento = Text,

            };

            if (ValidarForm())
            {
                if (Produtos.Salvar(produto))
                {
                    MessageBox.Show("Produto salvo com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao tentar salvar produto.");
                }
            }

        }
        private void txtb_Quantidade_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtb_Nome_Produto.Clear();
            txtb_Cod_Produto.Clear();
            txtb_Lote.Clear();
            txtb_Quantidade.Clear();
            txtb_Validade.Clear();
        }
        private bool ValidarForm()
        {
            if (txtb_Nome_Produto.Text == "")
            {
                MessageBox.Show("Informe o nome do produto.");
                txtb_Nome_Produto.Focus();
                return false;
            }
            else if (txtb_Cod_Produto.Text == "")
            {
                MessageBox.Show("Informe o código do produto.");
                txtb_Cod_Produto.Focus();
                return false;
            }
            else if (txtb_Lote.Text == "")
            {
                MessageBox.Show("Informe o lote do produto.");
                txtb_Lote.Focus();
                return false;
            }
            else if (txtb_Quantidade.Text == "")
            {
                MessageBox.Show("Informe a quantidade do produto.");
                txtb_Quantidade.Focus();
                return false;
            }
            else if (txtb_Validade.Text == "")
            {
                MessageBox.Show("Informe a validade do produto.");
                txtb_Validade.Focus();
                return false;
            }
            return true;
        }
        private void Relatorio_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirRelatorio();
        }

        private void ExibirRelatorio()
        {
            List<Produtos> produtos = Produtos.CarregarProdutos();

            if (produtos.Count > 0)
            {
                string relatorio = "Relatório de Produtos:\n\n\n";
                int i = 0;
                while (i < produtos.Count)
                {
                    var produto = produtos[i];
                    relatorio += $"Nome: {produto.NomeDoProduto}\n" +
                                 $"Código: {produto.CodigoDoProduto}\n" +
                                 $"Lote: {produto.Lote}\n" +
                                 $"Quantidade: {produto.Quantidade}\n" +
                                 $"Validade: {produto.Validade}\n" +
                                 $"Pré-Vencimento: {produto.PreVencimento}\n\n\n";
                    i++;
                }

                MessageBox.Show(relatorio, "Relatório de Produtos");
            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado.", "Relatório de Produtos");
            }
        }

        

    }
}