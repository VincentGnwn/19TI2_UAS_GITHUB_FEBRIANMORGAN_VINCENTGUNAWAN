
namespace JasaEkspedisi.UI
{
    partial class FormInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtJenisBarang = new System.Windows.Forms.TextBox();
            this.txtBeratBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlamatPenerima = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomorInvoice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOngkosKirim = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaPenerima = new System.Windows.Forms.TextBox();
            this.txtNamaKurir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvInvoice.Location = new System.Drawing.Point(43, 271);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(551, 270);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nomor Invoice";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jenis Barang";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Berat Barang";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nama Penerima";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Alamat Penerima";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nama Kurir";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ongkos Kirim";
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Berat Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBarang.Location = new System.Drawing.Point(164, 93);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.ReadOnly = true;
            this.txtNamaBarang.Size = new System.Drawing.Size(133, 26);
            this.txtNamaBarang.TabIndex = 6;
            // 
            // txtJenisBarang
            // 
            this.txtJenisBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisBarang.Location = new System.Drawing.Point(164, 127);
            this.txtJenisBarang.Name = "txtJenisBarang";
            this.txtJenisBarang.ReadOnly = true;
            this.txtJenisBarang.Size = new System.Drawing.Size(133, 26);
            this.txtJenisBarang.TabIndex = 7;
            // 
            // txtBeratBarang
            // 
            this.txtBeratBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeratBarang.Location = new System.Drawing.Point(164, 161);
            this.txtBeratBarang.Name = "txtBeratBarang";
            this.txtBeratBarang.ReadOnly = true;
            this.txtBeratBarang.Size = new System.Drawing.Size(133, 26);
            this.txtBeratBarang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nama Penerima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alamat Penerima";
            // 
            // txtAlamatPenerima
            // 
            this.txtAlamatPenerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatPenerima.Location = new System.Drawing.Point(472, 124);
            this.txtAlamatPenerima.Name = "txtAlamatPenerima";
            this.txtAlamatPenerima.ReadOnly = true;
            this.txtAlamatPenerima.Size = new System.Drawing.Size(121, 26);
            this.txtAlamatPenerima.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "No. Invoice";
            // 
            // txtNomorInvoice
            // 
            this.txtNomorInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorInvoice.Location = new System.Drawing.Point(164, 26);
            this.txtNomorInvoice.Name = "txtNomorInvoice";
            this.txtNomorInvoice.ReadOnly = true;
            this.txtNomorInvoice.Size = new System.Drawing.Size(133, 26);
            this.txtNomorInvoice.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ongkos Kirim";
            // 
            // txtOngkosKirim
            // 
            this.txtOngkosKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOngkosKirim.Location = new System.Drawing.Point(164, 196);
            this.txtOngkosKirim.Name = "txtOngkosKirim";
            this.txtOngkosKirim.ReadOnly = true;
            this.txtOngkosKirim.Size = new System.Drawing.Size(133, 26);
            this.txtOngkosKirim.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(503, 585);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(376, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nama Kurir";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(164, 59);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(133, 26);
            this.txtKodeBarang.TabIndex = 24;
            this.txtKodeBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodeBarang_KeyDown);
            // 
            // txtNamaPenerima
            // 
            this.txtNamaPenerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPenerima.Location = new System.Drawing.Point(472, 90);
            this.txtNamaPenerima.Name = "txtNamaPenerima";
            this.txtNamaPenerima.Size = new System.Drawing.Size(121, 26);
            this.txtNamaPenerima.TabIndex = 25;
            this.txtNamaPenerima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNamaPenerima_KeyDown);
            // 
            // txtNamaKurir
            // 
            this.txtNamaKurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaKurir.Location = new System.Drawing.Point(472, 58);
            this.txtNamaKurir.Name = "txtNamaKurir";
            this.txtNamaKurir.Size = new System.Drawing.Size(121, 26);
            this.txtNamaKurir.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(393, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 64);
            this.label7.TabIndex = 28;
            this.label7.Text = "Harga Ongkos Kirim :\r\n- 1 kg = 5.000\r\n- 2 s/d 5 kg = 20.000\r\n- >5 kg = 50.000";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(435, 547);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 26);
            this.txtTotal.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(421, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 26);
            this.textBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Image = global::JasaEkspedisi.Properties.Resources.loupe;
            this.button1.Location = new System.Drawing.Point(560, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JasaEkspedisi.Properties.Resources.back_left_arrow_circular_button_outline__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Image = global::JasaEkspedisi.Properties.Resources.keys1;
            this.btnCalculate.Location = new System.Drawing.Point(564, 546);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(30, 33);
            this.btnCalculate.TabIndex = 30;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Image = global::JasaEkspedisi.Properties.Resources.square_dice;
            this.btnRandom.Location = new System.Drawing.Point(303, 26);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(31, 26);
            this.btnRandom.TabIndex = 19;
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 626);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNamaKurir);
            this.Controls.Add(this.txtNamaPenerima);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOngkosKirim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtNomorInvoice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAlamatPenerima);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBeratBarang);
            this.Controls.Add(this.txtJenisBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInvoice);
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtJenisBarang;
        private System.Windows.Forms.TextBox txtBeratBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlamatPenerima;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomorInvoice;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOngkosKirim;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.TextBox txtNamaPenerima;
        private System.Windows.Forms.TextBox txtNamaKurir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}