using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Produtos p = new Produtos();
            p.lerProduto();

            //Clientes c = new Clientes();
            //c.lerClientes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.lerClientes();
        }
    }
}
