using MySql.Data.MySqlClient;
using ProJeto_Banco_de_Dados.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJeto_Banco_de_Dados.Telas
{
    public partial class TelaLoginComandos : Form
    {
        

        public TelaLoginComandos()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txbSenha.Text.ToString();
            if (txbUsuario.Text.Equals("Admin") && txbSenha.Text.Equals("123456"))
            {
                TelaComandoSql telaComando = new TelaComandoSql();
                telaComando.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Invalidos!!");
            }

            
        }
    }
}
