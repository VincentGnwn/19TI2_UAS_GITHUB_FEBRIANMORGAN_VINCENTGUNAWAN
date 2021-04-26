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
    public partial class FormPenerima : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public FormPenerima()
        {
            InitializeComponent();
        }

        void loadDataPenerima(string kodePos)
        {
            dgvPenerima.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Penerima where kodepos_penerima like '%" + kodePos + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Penerima obj = new Penerima();
                    obj.NamaPenerima = row[1].ToString();
                    obj.AlamatPenerima = row[2].ToString();
                    obj.KodePosPenerima = row[3].ToString();
                    obj.NoTelp = row[4].ToString();
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

        private void populate(Penerima obj)
        {
            dgvPenerima.Rows.Add(obj.NamaPenerima, obj.AlamatPenerima, obj.KodePosPenerima, obj.NoTelp);
        }


        private void FormPenerima_Load(object sender, EventArgs e)
        {
            loadDataPenerima("");
        }

        private void add(Penerima obj)
        {
            const string sql = "Insert into Penerima(Nama_Penerima, Alamat_Penerima, Kodepos_Penerima, No_Telp) values(@namaPenerima, @alamatPenerima, @kodeposPenerima ,@noTelp )";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@namaPenerima", obj.NamaPenerima);
            cmd.Parameters.AddWithValue("@alamatPenerima", obj.AlamatPenerima);
            cmd.Parameters.AddWithValue("@kodeposPenerima", obj.KodePosPenerima);
            cmd.Parameters.AddWithValue("@noTelp", obj.NoTelp);
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

        private void update(Penerima obj)
        {
            string sql = "UPDATE Penerima set Nama_Penerima='" + obj.NamaPenerima + "', Alamat_Penerima='" + obj.AlamatPenerima + "', No_Telp='" + obj.NoTelp + "'where kodepos_penerima='" + obj.KodePosPenerima + "'";
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

        private void delete(Penerima obj)
        {
            string sql = "DELETE FROM Penerima WHERE kodepos_penerima='" + obj.KodePosPenerima + "'";
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
                int i;
                int j;
                if (txtNamaPenerima.Text == "" || txtAlamatPenerima.Text == "" || txtKodePosPenerima.Text == "" || txtNoTelp.Text == "")
                {
                    MessageBox.Show("Inputan tidak boleh kosong");
                }
                else if (txtKodePosPenerima.Text.Length != 5)
                {
                    MessageBox.Show("Kode Pos harus berjumlah 5");
                }
                else if (txtNoTelp.Text.Length != 11)
                {
                    MessageBox.Show("Nomor Telepon harus berjumlah 11");
                }
                else if (Int32.TryParse(txtKodePosPenerima.Text, out i) && Int32.TryParse(txtNoTelp.Text, out j))
                {

                }
                    try
                    {
                        Penerima obj = new Penerima();
                        obj.NamaPenerima = txtNamaPenerima.Text.Trim();
                        obj.AlamatPenerima = txtAlamatPenerima.Text.Trim();
                        obj.KodePosPenerima = txtKodePosPenerima.Text.Trim();
                        obj.NoTelp = txtNoTelp.Text.Trim();
                        add(obj);
                        MessageBox.Show("Data berhasil disimpan");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Update Data?", "Update Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                try
                {
                    Penerima obj = new Penerima();
                    obj.NamaPenerima = txtNamaPenerima.Text.Trim();
                    obj.AlamatPenerima = txtAlamatPenerima.Text.Trim();
                    obj.KodePosPenerima = txtKodePosPenerima.Text.Trim();
                    obj.NoTelp = txtNoTelp.Text.Trim();
                    update(obj);
                    loadDataPenerima("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
        }

        private void dgvPenerima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvPenerima.Rows[e.RowIndex];
            txtNamaPenerima.Text = baris.Cells[0].Value.ToString();
            txtAlamatPenerima.Text = baris.Cells[1].Value.ToString();
            txtKodePosPenerima.Text = baris.Cells[2].Value.ToString();
            txtNoTelp.Text = baris.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Delete Data?", "Hapus Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Penerima obj = new Penerima();
                    obj.NamaPenerima = txtNamaPenerima.Text.Trim();
                    obj.AlamatPenerima = txtAlamatPenerima.Text.Trim();
                    obj.KodePosPenerima = txtKodePosPenerima.Text.Trim();
                    obj.NoTelp = txtNoTelp.Text.Trim();
                    delete(obj);
                    loadDataPenerima("");
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

        private void txtKodePosPenerima_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
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
