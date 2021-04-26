using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using JasaEkspedisi.Model;

namespace JasaEkspedisi.UI
{
    public partial class FormLogin : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ASUS/source/repos/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string psw = txtPassword.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login where username_login='" + txtUsername.Text + "' AND password_login='" + txtPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FormMenu fm = new FormMenu();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreate fc = new FormCreate();
            fc.Show();
            this.Hide();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (cbShow.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
