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

namespace JasaEkspedisi
{
    public partial class FormBarang : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public FormBarang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            loadDataBarang("");
        }

        void loadDataBarang(string namaBarang)
        {
            dgvBarang.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Barang where nama_barang like '%" + namaBarang + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Barang obj = new Barang();
                    obj.NamaBarang = row[1].ToString();
                    obj.KodeBarang = row[2].ToString();
                    obj.JenisBarang = row[3].ToString();
                    obj.BeratBarang = Int32.Parse(row[4].ToString());
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

        private void populate(Barang obj)
        {
            dgvBarang.Rows.Add(obj.NamaBarang, obj.KodeBarang, obj.JenisBarang, obj.BeratBarang);
        }

        private void add(Barang obj)
        {
            const string sql = "Insert into Barang(Nama_Barang, Kode_Barang, Jenis_Barang,Berat_Barang) values(@namaBarang, @kodeBarang, @jenisBarang,@beratBarang )";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@namaBarang", obj.NamaBarang);
            cmd.Parameters.AddWithValue("@kodeBarang", obj.KodeBarang);
            cmd.Parameters.AddWithValue("@jenisBarang", obj.JenisBarang);
            cmd.Parameters.AddWithValue("@beratBarang", obj.BeratBarang);
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

        private void update(Barang obj)
        {
            string sql = "UPDATE Barang set Nama_Barang='" + obj.NamaBarang + "', Jenis_barang='" + obj.JenisBarang + "', Berat_barang='" + obj.BeratBarang + "'where Kode_Barang='" + obj.KodeBarang + "'";
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

        private void delete(Barang obj)
        {
            string sql = "DELETE FROM Barang WHERE Kode_Barang='" + obj.KodeBarang + "'";
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
                    Barang obj = new Barang();
                    obj.NamaBarang = txtNamaBarang.Text.Trim();
                    obj.KodeBarang = txtKodeBarang.Text.Trim();
                    obj.JenisBarang = txtJenisBarang.Text.Trim();
                    obj.BeratBarang = Int32.Parse(txtBeratBarang.Text.Trim());
                    add(obj);
                    MessageBox.Show("Data berhasil disimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masukkan angka pada bagian harga");
                }
            }
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvBarang.Rows[e.RowIndex];
            txtNamaBarang.Text = baris.Cells[0].Value.ToString();
            txtKodeBarang.Text = baris.Cells[1].Value.ToString();
            txtJenisBarang.Text = baris.Cells[2].Value.ToString();
            txtBeratBarang.Text = baris.Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Barang obj = new Barang();
            obj.NamaBarang = txtNamaBarang.Text.Trim();
            obj.KodeBarang = txtKodeBarang.Text.Trim();
            obj.JenisBarang = txtJenisBarang.Text.Trim();
            obj.BeratBarang = Int32.Parse(txtBeratBarang.Text.Trim());
            update(obj);
            loadDataBarang("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Barang obj = new Barang();
            obj.NamaBarang = txtNamaBarang.Text.Trim();
            obj.KodeBarang = txtKodeBarang.Text.Trim();
            obj.JenisBarang = txtJenisBarang.Text.Trim();
            obj.BeratBarang = Int32.Parse(txtBeratBarang.Text.Trim());
            delete(obj);
            loadDataBarang("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.Show();
            this.Hide();
        }

        private void txtBeratBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBeratBarang_KeyPress(object sender, KeyPressEventArgs e)
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
