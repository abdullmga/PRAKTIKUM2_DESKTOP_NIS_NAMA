namespace PRAKTIKUM2_DESKTOP_NIS_NAMA
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxKodeBahan = new System.Windows.Forms.TextBox();
            this.txtBoxNamaBahan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSatuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxHargaSatuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxBatasMinimum = new System.Windows.Forms.TextBox();
            this.kolomKodeBahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomNamaBahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomHargaSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomBatasMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Stok Bahan Baku";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKodeBahan,
            this.kolomNamaBahan,
            this.kolomKategori,
            this.kolomStok,
            this.kolomSatuan,
            this.kolomHargaSatuan,
            this.kolomBatasMinimum});
            this.dataGridView1.Location = new System.Drawing.Point(236, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(736, 393);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KODE BAHAN";
            // 
            // txtBoxKodeBahan
            // 
            this.txtBoxKodeBahan.Location = new System.Drawing.Point(12, 29);
            this.txtBoxKodeBahan.Name = "txtBoxKodeBahan";
            this.txtBoxKodeBahan.Size = new System.Drawing.Size(181, 20);
            this.txtBoxKodeBahan.TabIndex = 3;
            // 
            // txtBoxNamaBahan
            // 
            this.txtBoxNamaBahan.Location = new System.Drawing.Point(12, 82);
            this.txtBoxNamaBahan.Name = "txtBoxNamaBahan";
            this.txtBoxNamaBahan.Size = new System.Drawing.Size(181, 20);
            this.txtBoxNamaBahan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NAMA BAHAN";
            // 
            // cmbBoxKategori
            // 
            this.cmbBoxKategori.FormattingEnabled = true;
            this.cmbBoxKategori.Items.AddRange(new object[] {
            "Biji Kopi",
            "Susu & Dairy",
            "Sirup & Pemanis",
            "Kemasan"});
            this.cmbBoxKategori.Location = new System.Drawing.Point(12, 131);
            this.cmbBoxKategori.Name = "cmbBoxKategori";
            this.cmbBoxKategori.Size = new System.Drawing.Size(181, 21);
            this.cmbBoxKategori.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "KATEGORI";
            // 
            // txtBoxSatuan
            // 
            this.txtBoxSatuan.Location = new System.Drawing.Point(12, 225);
            this.txtBoxSatuan.Name = "txtBoxSatuan";
            this.txtBoxSatuan.Size = new System.Drawing.Size(181, 20);
            this.txtBoxSatuan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SATUAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "HARGA SATUAN";
            // 
            // txtBoxHargaSatuan
            // 
            this.txtBoxHargaSatuan.Location = new System.Drawing.Point(12, 277);
            this.txtBoxHargaSatuan.Name = "txtBoxHargaSatuan";
            this.txtBoxHargaSatuan.Size = new System.Drawing.Size(181, 20);
            this.txtBoxHargaSatuan.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "STOK";
            // 
            // txtBoxStok
            // 
            this.txtBoxStok.Location = new System.Drawing.Point(12, 176);
            this.txtBoxStok.Name = "txtBoxStok";
            this.txtBoxStok.Size = new System.Drawing.Size(181, 20);
            this.txtBoxStok.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "BATAS MINIMUM";
            // 
            // txtBoxBatasMinimum
            // 
            this.txtBoxBatasMinimum.Location = new System.Drawing.Point(12, 325);
            this.txtBoxBatasMinimum.Name = "txtBoxBatasMinimum";
            this.txtBoxBatasMinimum.Size = new System.Drawing.Size(181, 20);
            this.txtBoxBatasMinimum.TabIndex = 16;
            // 
            // kolomKodeBahan
            // 
            this.kolomKodeBahan.HeaderText = "KODE BAHAN";
            this.kolomKodeBahan.Name = "kolomKodeBahan";
            this.kolomKodeBahan.ReadOnly = true;
            // 
            // kolomNamaBahan
            // 
            this.kolomNamaBahan.HeaderText = "NAMA BAHAN";
            this.kolomNamaBahan.Name = "kolomNamaBahan";
            this.kolomNamaBahan.ReadOnly = true;
            // 
            // kolomKategori
            // 
            this.kolomKategori.HeaderText = "KATEGORI";
            this.kolomKategori.Name = "kolomKategori";
            this.kolomKategori.ReadOnly = true;
            // 
            // kolomStok
            // 
            this.kolomStok.HeaderText = "STOK";
            this.kolomStok.Name = "kolomStok";
            this.kolomStok.ReadOnly = true;
            // 
            // kolomSatuan
            // 
            this.kolomSatuan.HeaderText = "SATUAN";
            this.kolomSatuan.Name = "kolomSatuan";
            this.kolomSatuan.ReadOnly = true;
            // 
            // kolomHargaSatuan
            // 
            this.kolomHargaSatuan.HeaderText = "HARGA SATUAN";
            this.kolomHargaSatuan.Name = "kolomHargaSatuan";
            this.kolomHargaSatuan.ReadOnly = true;
            // 
            // kolomBatasMinimum
            // 
            this.kolomBatasMinimum.HeaderText = "BATAS MINIMUM";
            this.kolomBatasMinimum.Name = "kolomBatasMinimum";
            this.kolomBatasMinimum.ReadOnly = true;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(12, 362);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(89, 34);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(333, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 34);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(236, 437);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(91, 34);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(104, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 34);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtBoxBatasMinimum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxHargaSatuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxSatuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxKategori);
            this.Controls.Add(this.txtBoxNamaBahan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxKodeBahan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxKodeBahan;
        private System.Windows.Forms.TextBox txtBoxNamaBahan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSatuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxHargaSatuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxBatasMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKodeBahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomNamaBahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomHargaSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomBatasMinimum;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
    }
}

