using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teste2
{
    class Arquivo

    {
        
        StreamWriter sw;
        public void criaAbreArquivoProdutos()
        {

            sw = new StreamWriter(@"D:\Produtos.txt", true, Encoding.UTF8);
            sw.WriteLine("ID-CodEAN-Nome-preco-estoque");
            //sw.Close();
        }

        public void gerarProduto(int id, string CodEan, string nome, double preco, int estoque)
        {
            
            sw.WriteLine(id + "-" + CodEan + "-" + nome + "-" + preco + "-" + estoque);

            
        }

        public void gerarCliente(int id, string cpf, string nome, string telefone, string email)
        {

            sw.WriteLine(id + "-" + cpf + "-" + nome + "-" + telefone + "-" + email);


        }

        public void criaAbreArquivoClientes()
        {

            sw = new StreamWriter(@"D:\Cliente.txt", true, Encoding.UTF8);
            sw.WriteLine("ID-Cpf-Nome-Telefone-Email");
            //sw.Close();
        }
        public void fechaArquivo()
        {
            sw.Close();
        }
        

    }
}
