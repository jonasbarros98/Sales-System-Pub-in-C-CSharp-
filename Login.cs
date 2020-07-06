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
    public partial class Login : Form
    {
        public Login()
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

                if (txtLogin.Text != string.Empty)
                {
                    if (i == 0)
                    {
                        MessageBox.Show("Usuario ou senha incorretos");
                    }
                    else
                    {
                        this.Hide();
                        TelaMenu fm = new TelaMenu(txtLogin.Text); 
                        fm.Show();
                        cmd.CommandText = ("SELECT login FROM usuarios where login = '" + txtLogin.Text + "'");

                    }
                }
                else
                {
                    MessageBox.Show("DIGITE OS DADOS DE LOGIN", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLogin.Focus();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro na execução do comando: ");
            }
            
                Conexao.Close();

        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
       
       
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
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            //código para deixar o groupBox do login quase transparente
            
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            txtLogin.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
