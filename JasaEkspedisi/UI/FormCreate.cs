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
    public partial class FormCreate : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public FormCreate()
        {
            InitializeComponent();
        }

        private void add(Login obj)
        {
            const string sql = "Insert into Login(username_login, password_login) values(@username_login, @password_login)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@username_login", obj.User);
            cmd.Parameters.AddWithValue("@password_login", obj.Password);
            try
            {
                dbConn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Berhasil simpan ke database");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Create New Account ?", "Create Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Login obj = new Login();
                    obj.User = txtUsername.Text.Trim();
                    obj.Password = txtPassword.Text.Trim();
                    add(obj);
                    FormLogin fl = new FormLogin();
                    fl.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {

        }
    }
    }
