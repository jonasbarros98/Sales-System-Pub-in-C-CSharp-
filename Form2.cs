using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudExemplos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud;password=masterkey");
            Conexao.Open();

            int i = 0;

            try
            {
                MySqlCommand cmd = Conexao.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("select * from usuarios where login ='" + txtLogin.Text + "' and senha ='" + txtSenha.Text + "'");

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                MessageBox.Show(""+ cmd);
                if (i == 0)
                {
                    MessageBox.Show("Usuario ou senha incorretos"+i);
                }
                else
                {
                    this.Hide();
                    TelaMenu fm = new TelaMenu();
                    fm.Show();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na execução do comando: "+erro);
            }

                Conexao.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*public class Login : Form2
        {
            public string usuario
            {
                get { return txtuserlogado.Text; }
                
            }
            
        }*/
       
        private void button3_Click(object sender, EventArgs e)
        {
            TelaMenu fm3 = new TelaMenu();
            fm3.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

    }
}
