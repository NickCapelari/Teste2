using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2
{
    class Produtos
    {
        private int _id;
        private string _codEAN, _nome;
        private double _preco;
        private int _estoque;

        public int Id { get => _id; set => _id = value; }
        public string CodEan{ get => _codEAN; set => _codEAN = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public int Estoque { get => _estoque; set => _estoque = value; }

        public void lerProduto ()
        {
            Arquivo a = new Arquivo();
            a.criaAbreArquivoProdutos();
            Banco bd = new Banco();
            int count = 0;
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("Select * from produtos", cn);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    if (reader.GetInt32(3) > 0)
                    {
                        count++;
                        Id = count;
                        _codEAN = reader.GetString(0);
                        _nome = reader.GetString(1);
                        _preco = reader.GetDouble(2);
                        _estoque = reader.GetInt32(3);
                        MessageBox.Show(Id + " " + _codEAN + " " + _nome + " " + _preco + " " + _estoque);
                        a.gerarProduto(_id, _codEAN, _nome, _preco, _estoque);
                        
                    }
                }




            }
            catch (Exception)
            {

                return;
            }
            finally
            {
                a.fechaArquivo();
            }
        }
    }
}
