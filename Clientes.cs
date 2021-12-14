using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2
{
    class Clientes
    {
        private int _id;
        private string _cpf, _nome, _telefone, _email;

        public int Id { get => _id; set => _id = value; }
        public string cpf { get => _cpf; set => _cpf = value; }
        public string nome { get => _nome; set => _nome = value; }
        public string telefone { get => _telefone; set => _telefone = value; }
        public string email { get => _email; set => _email = value; }
        public void lerClientes()
        {
            Arquivo a = new Arquivo();
            a.criaAbreArquivoClientes();
            Banco bd = new Banco();
            int count = 0;
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("Select cpf, Nome, ISNULL(Telefone,''), Email from clientes where nome <> '' or nome <> null", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {          
                       
                        count++;
                        _id = count;
                        _cpf = reader.GetString(0);
                        _nome = reader.GetString(1);              
                        _telefone = reader.GetString(2);
                        _email = reader.GetString(3);
                        MessageBox.Show(_id + " " + _cpf + " " + _nome + " " + _telefone + " " + _email);
                        a.gerarCliente(_id, _cpf, _nome, _telefone, _email);
                }
                return;



            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                return;
            }
            finally
            {
                a.fechaArquivo();
            }

        }
    }
}
