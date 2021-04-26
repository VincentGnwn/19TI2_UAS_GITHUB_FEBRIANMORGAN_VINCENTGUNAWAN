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
    public partial class FormInvoice : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=I:/JasaEkspedisi/DB/DB_JasaEkspedisi.accdb;Persist Security Info = False;";
        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        public FormInvoice()
        {
            InitializeComponent();
        }

        private Barang getDataBarang(string kodeBarang)
        {
            Barang obj = new Barang();
            try
            {
                String sql = "SELECT * FROM Barang where Kode_Barang='" + kodeBarang + "'";
                cmd = new OleDbCommand(sql, dbConn);

                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                //LOOP THROUGH DATATABLE 
                foreach (DataRow row in dt.Rows)
                {
                    obj.NamaBarang = row[2].ToString();
                    obj.KodeBarang = row[1].ToString();
                    obj.JenisBarang = row[3].ToString();
                    obj.BeratBarang = Int32.Parse(row[4].ToString());
                }
                dbConn.Close();
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //dbConnection.Close();
            }
            finally
            {
                dbConn.Close();
            }
            return obj;
        }

        private Penerima getDataPenerima(string namaPenerima)
        {
            Penerima obj = new Penerima();
            try
            {
                String sql = "SELECT * FROM Penerima where nama_penerima='" + namaPenerima + "'";
                cmd = new OleDbCommand(sql, dbConn);

                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                //LOOP THROUGH DATATABLE 
                foreach (DataRow row in dt.Rows)
                {
                    obj.NamaPenerima = row[5].ToString();
                    obj.AlamatPenerima = row[6].ToString();
                }
                dbConn.Close();
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //dbConnection.Close();
            }
            finally
            {
                dbConn.Close();
            }
            return obj;
        }

        void loadDataInvoice(string noInvoice)
        {
            dgvInvoice.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Invoice where nomor_invoice like '%" + noInvoice + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Invoice obj = new Invoice();
                    obj.NomorInvoice = row[1].ToString();
                    obj.NamaBarang = row[2].ToString();
                    obj.JenisBarang = row[3].ToString();
                    obj.BeratBarang = Int32.Parse(row[4].ToString());
                    obj.NamaPenerima = row[5].ToString();
                    obj.AlamatPenerima = row[6].ToString();
                    obj.NamaKurir = row[7].ToString();
                    obj.OngkosKirim = Int32.Parse(row[8].ToString());
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

        private void add(Invoice obj)
        {
            const string sql = "Insert into Invoice(Nomor_Invoice, Nama_Barang, Jenis_Barang, Berat_Barang, Nama_Penerima, Alamat_Penerima, Nama_Kurir, Ongkos_Kirim) values(@nomorInvoice, @namaBarang, @jenisBarang, @beratBarang, @namaPenerima, @alamatPenerima, @namaKurir, @ongkosKirim)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@nomorInvoice", obj.NomorInvoice);
            cmd.Parameters.AddWithValue("@namaBarang", obj.NamaBarang);
            cmd.Parameters.AddWithValue("@jenisBarang", obj.JenisBarang);
            cmd.Parameters.AddWithValue("@beratBarang", obj.BeratBarang);
            cmd.Parameters.AddWithValue("@namaPenerima", obj.NamaPenerima);
            cmd.Parameters.AddWithValue("@alamatPenerima", obj.AlamatPenerima);
            cmd.Parameters.AddWithValue("@namaKurir", obj.NamaKurir);
            cmd.Parameters.AddWithValue("@ongkosKirim", obj.OngkosKirim);
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

        private void populate(Invoice obj)
        {
            dgvInvoice.Rows.Add(obj.NomorInvoice, obj.NamaBarang, obj.JenisBarang, obj.BeratBarang, obj.NamaPenerima, obj.AlamatPenerima, obj.NamaKurir, obj.OngkosKirim);
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            loadDataInvoice("");
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow baris = dgvInvoice.Rows[e.RowIndex];
            //txtNomorInvoice.Text = baris.Cells[0].Value.ToString();
            //txtNamaBarang.Text = baris.Cells[1].Value.ToString();
            //txtJenisBarang.Text = baris.Cells[2].Value.ToString();
            //txtNamaPenerima.Text = baris.Cells[3].Value.ToString();
            //txtAlamatPenerima.Text = baris.Cells[4].Value.ToString();
            //txtNamaKurir.Text = baris.Cells[5].Value.ToString();
            //txtOngkosKirim.Text = baris.Cells[6].Value.ToString();
        }

        private void txtKodeBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNamaPenerima_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string r = "INV/";
            int i;
            for (i = 1; i < 8; i++)
            {
                r += rnd.Next(0, 9).ToString();
            }
            txtNomorInvoice.Text = r;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Save Data?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Invoice obj = new Invoice();
                    obj.NomorInvoice = txtNomorInvoice.Text.Trim();
                    obj.NamaBarang = txtNamaBarang.Text.Trim();
                    obj.JenisBarang = txtJenisBarang.Text.Trim();
                    obj.BeratBarang = Int32.Parse(txtBeratBarang.Text.Trim());
                    obj.NamaPenerima = txtNamaPenerima.Text.Trim();
                    obj.AlamatPenerima = txtAlamatPenerima.Text.Trim();
                    obj.NamaKurir = txtNamaKurir.Text.Trim();
                    obj.OngkosKirim = Int32.Parse(txtOngkosKirim.Text.Trim());
                    add(obj);
                    MessageBox.Show("Data berhasil disimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void txtNamaPenerima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Penerima obj = getDataPenerima(txtNamaPenerima.Text.Trim());
                txtNamaPenerima.Text = obj.NamaPenerima;
                txtAlamatPenerima.Text = obj.AlamatPenerima;
            }
        }

        private void txtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Barang obj = getDataBarang(txtKodeBarang.Text.Trim());
                txtNamaBarang.Text = obj.NamaBarang;
                txtJenisBarang.Text = obj.JenisBarang;
                txtBeratBarang.Text = obj.BeratBarang.ToString();
                if (Int32.Parse(txtBeratBarang.Text) == 1)
                {
                    txtOngkosKirim.Text = "5000";
                }
                else if (Int32.Parse(txtBeratBarang.Text) >= 2 && Int32.Parse(txtBeratBarang.Text) <= 5)
                {
                    txtOngkosKirim.Text = "20000";
                }
                else if (Int32.Parse(txtBeratBarang.Text) >= 5)
                {
                    txtOngkosKirim.Text = "50000";
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvInvoice.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvInvoice.Rows[i].Cells[7].Value);
            }
            txtTotal.Text = sum.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDataInvoice(textBox1.Text.Trim());
        }
    }
}
