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
    public partial class FormKurir : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public FormKurir()
        {
            InitializeComponent();
        }

        void loadDataKurir(string noKtp)
        {
            dgvKurir.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Kurir where no_ktp like '%" + noKtp + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Kurir obj = new Kurir();
                    obj.NamaKurir = row[1].ToString();
                    obj.UmurKurir = Int32.Parse(row[2].ToString());
                    obj.GenderKurir = row[3].ToString();
                    obj.NoKtp = row[4].ToString();
                    populate(obj);
                }
                dbConn.Close();
                dt.Rows.Clear();
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

        private void populate(Kurir obj)
        {
            dgvKurir.Rows.Add(obj.NamaKurir, obj.UmurKurir, obj.GenderKurir, obj.NoKtp);
        }

        private void add(Kurir obj)
        {
            const string sql = "Insert into Kurir(Nama_Kurir, Umur_Kurir, Gender_Kurir, No_Ktp) values(@namaKurir, @umurKurir, @genderKurir ,@noKtp )";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@namaKurir", obj.NamaKurir);
            cmd.Parameters.AddWithValue("@umurKurir", obj.UmurKurir);
            cmd.Parameters.AddWithValue("@genderkurir", obj.GenderKurir);
            cmd.Parameters.AddWithValue("@noKtp", obj.NoKtp);
            populate(obj);
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

        private void update(Kurir obj)
        {
            string sql = "UPDATE Kurir set Nama_Kurir='" + obj.NamaKurir + "', Umur_Kurir='" + obj.UmurKurir + "', Gender_Kurir='" + obj.GenderKurir + "', No_Ktp='" + obj.NoKtp + "'where No_KTP='" + obj.NoKtp + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { UpdateCommand = dbConn.CreateCommand() };

                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Berhasil ubah data ke database");

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

        private void delete(Kurir obj)
        {
            string sql = "DELETE FROM Kurir WHERE No_Ktp='" + obj.NoKtp + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { DeleteCommand = dbConn.CreateCommand() };

                adapter.DeleteCommand.CommandText = sql;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Berhasil menghapus data dalam database");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Save Data?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string value = "";
                    bool isChecked = rbMale.Checked;
                    if (isChecked)
                        value = rbMale.Text;
                    else
                        value = rbFemale.Text;

                    Kurir obj = new Kurir();
                    obj.NamaKurir = txtNamaKurir.Text.Trim();
                    obj.UmurKurir = Int32.Parse(txtUmurKurir.Text.Trim());
                    obj.GenderKurir = value;
                    obj.NoKtp = txtNoKTP.Text.Trim();
                    add(obj);
                    MessageBox.Show("Data berhasil disimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void FormKurir_Load(object sender, EventArgs e)
        {
            loadDataKurir("");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Update Data?", "Update Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                try
                {
                    string value = "";
                    bool isChecked = rbMale.Checked;
                    if (isChecked)
                        value = rbMale.Text;
                    else
                        value = rbFemale.Text;

                    Kurir obj = new Kurir();
                    obj.NamaKurir = txtNamaKurir.Text.Trim();
                    obj.UmurKurir = Int32.Parse(txtUmurKurir.Text.Trim());
                    obj.GenderKurir = value;
                    obj.NoKtp = txtNoKTP.Text.Trim();
                    update(obj);
                    loadDataKurir("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
        }

        private void dgvKurir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvKurir.Rows[e.RowIndex];
            txtNamaKurir.Text = baris.Cells[0].Value.ToString();
            txtUmurKurir.Text = baris.Cells[1].Value.ToString();
            if (baris.Cells[2].FormattedValue.Equals("Male"))
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtNoKTP.Text = baris.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Delete Data?", "Hapus Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string value = "";
                    bool isChecked = rbMale.Checked;
                    if (isChecked)
                        value = rbMale.Text;
                    else
                        value = rbFemale.Text;

                    Kurir obj = new Kurir();
                    obj.NamaKurir = txtNamaKurir.Text.Trim();
                    obj.UmurKurir = Int32.Parse(txtUmurKurir.Text.Trim());
                    obj.GenderKurir = value;
                    obj.NoKtp = txtNoKTP.Text.Trim();
                    delete(obj);
                    loadDataKurir("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.Show();
            this.Hide();
        }

        private void txtUmurKurir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUmurKurir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNoKTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
