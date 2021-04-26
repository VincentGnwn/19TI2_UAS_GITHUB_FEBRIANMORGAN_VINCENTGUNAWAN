
namespace JasaEkspedisi.UI
{
    partial class FormPenerima
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPenerima = new System.Windows.Forms.TextBox();
            this.txtAlamatPenerima = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtKodePosPenerima = new System.Windows.Forms.TextBox();
            this.dgvPenerima = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Penerima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat Penerima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Pos Penerima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Telepon Penerima";
            // 
            // txtNamaPenerima
            // 
            this.txtNamaPenerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPenerima.Location = new System.Drawing.Point(237, 28);
            this.txtNamaPenerima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamaPenerima.Name = "txtNamaPenerima";
            this.txtNamaPenerima.Size = new System.Drawing.Size(297, 26);
            this.txtNamaPenerima.TabIndex = 4;
            // 
            // txtAlamatPenerima
            // 
            this.txtAlamatPenerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatPenerima.Location = new System.Drawing.Point(237, 74);
            this.txtAlamatPenerima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlamatPenerima.Name = "txtAlamatPenerima";
            this.txtAlamatPenerima.Size = new System.Drawing.Size(297, 26);
            this.txtAlamatPenerima.TabIndex = 5;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTelp.Location = new System.Drawing.Point(237, 164);
            this.txtNoTelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(297, 26);
            this.txtNoTelp.TabIndex = 6;
            this.txtNoTelp.TextChanged += new System.EventHandler(this.txtNoTelp_TextChanged);
            this.txtNoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTelp_KeyPress);
            // 
            // txtKodePosPenerima
            // 
            this.txtKodePosPenerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodePosPenerima.Location = new System.Drawing.Point(237, 118);
            this.txtKodePosPenerima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKodePosPenerima.Name = "txtKodePosPenerima";
            this.txtKodePosPenerima.Size = new System.Drawing.Size(297, 26);
            this.txtKodePosPenerima.TabIndex = 7;
            this.txtKodePosPenerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodePosPenerima_KeyPress);
            // 
            // dgvPenerima
            // 
            this.dgvPenerima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenerima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPenerima.Location = new System.Drawing.Point(47, 269);
            this.dgvPenerima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPenerima.Name = "dgvPenerima";
            this.dgvPenerima.Size = new System.Drawing.Size(495, 242);
            this.dgvPenerima.TabIndex = 8;
            this.dgvPenerima.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenerima_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama Penerima";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Alamat Penerima";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kode Pos Penerima";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No. Telepon Penerima";
            this.Column4.Name = "Column4";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(60, 215);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(212, 215);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 34);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(360, 215);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JasaEkspedisi.Properties.Resources.back_left_arrow_circular_button_outline__2_;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPenerima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPenerima);
            this.Controls.Add(this.txtKodePosPenerima);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamatPenerima);
            this.Controls.Add(this.txtNamaPenerima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPenerima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPenerima";
            this.Load += new System.EventHandler(this.FormPenerima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaPenerima;
        private System.Windows.Forms.TextBox txtAlamatPenerima;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtKodePosPenerima;
        private System.Windows.Forms.DataGridView dgvPenerima;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}