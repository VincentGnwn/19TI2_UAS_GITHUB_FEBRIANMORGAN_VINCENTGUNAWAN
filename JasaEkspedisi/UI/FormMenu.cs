using JasaEkspedisi.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasaEkspedisi
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void kurirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKurir fk = new FormKurir();
            fk.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang fb = new FormBarang();
            fb.Show();
            this.Hide();
        }

        private void penerimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenerima fp = new FormPenerima();
            fp.Show();
            this.Hide();
        }

        private void saleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoice fi = new FormInvoice();
            fi.Show();
            this.Hide();
        }
    }
}
