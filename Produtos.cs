using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Gerador_de_Relatorios_de_Produtos_Pre_Vencidos
{
    public class Produtos
    {
        public string NomeDoProduto { get; set; }
        public string CodigoDoProduto { get; set; }
        public string Lote { get; set; }
        public string Quantidade { get; set; }
        public string Validade { get; set; }
        public string PreVencimento { get; set; }
        public static bool Salvar(Produtos produto)
        {
            try
            {
                DateTime dataValidade = DateTime.Parse(produto.Validade);
                DateTime dataPreVencimento = dataValidade.AddMonths(-3);
                produto.PreVencimento = dataPreVencimento.ToString("dd/MM/yyyy");

                using (var sw = new StreamWriter("C:\\Users\\Helen Mota\\Desktop\\Produtos.txt", true))
                {
                    sw.WriteLine(produto.NomeDoProduto);
                    sw.WriteLine(produto.CodigoDoProduto);
                    sw.WriteLine(produto.Lote);
                    sw.WriteLine(produto.Quantidade);
                    sw.WriteLine(produto.Validade);
                    sw.WriteLine(produto.PreVencimento);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar dados: " + ex.Message);
                return false;
            }
        }

        public static List<Produtos> CarregarProdutos()
        {
            List<Produtos> produtos = new List<Produtos>();

            try
            {
                if (File.Exists("C:\\Users\\Helen Mota\\Desktop\\Produtos.txt"))
                {
                    string[] linhas = File.ReadAllLines("C:\\Users\\Helen Mota\\Desktop\\Produtos.txt");

                    for (int i = 0 ; i < linhas.Length; i += 6)
                    {
                        Produtos produto = new Produtos
                        {
                            NomeDoProduto = linhas[i],
                            CodigoDoProduto = linhas[i + 1],
                            Lote = linhas[i + 2],
                            Quantidade = linhas[i + 3],
                            Validade = linhas[i + 4],
                            PreVencimento = linhas[i + 5]
                           
                        };
                        produtos.Add(produto);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar dados: " + ex.Message);
            }

            return produtos;
        }
      
    }
}