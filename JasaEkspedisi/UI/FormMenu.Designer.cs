
namespace JasaEkspedisi
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(561, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.kurirToolStripMenuItem,
            this.penerimaToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // kurirToolStripMenuItem
            // 
            this.kurirToolStripMenuItem.Name = "kurirToolStripMenuItem";
            this.kurirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.kurirToolStripMenuItem.Text = "Kurir";
            this.kurirToolStripMenuItem.Click += new System.EventHandler(this.kurirToolStripMenuItem_Click);
            // 
            // penerimaToolStripMenuItem
            // 
            this.penerimaToolStripMenuItem.Name = "penerimaToolStripMenuItem";
            this.penerimaToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.penerimaToolStripMenuItem.Text = "Penerima";
            this.penerimaToolStripMenuItem.Click += new System.EventHandler(this.penerimaToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleInvoiceToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // saleInvoiceToolStripMenuItem
            // 
            this.saleInvoiceToolStripMenuItem.Name = "saleInvoiceToolStripMenuItem";
            this.saleInvoiceToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.saleInvoiceToolStripMenuItem.Text = "Sale Invoice";
            this.saleInvoiceToolStripMenuItem.Click += new System.EventHandler(this.saleInvoiceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 362);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penerimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleInvoiceToolStripMenuItem;
    }
}

