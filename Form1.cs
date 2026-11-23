using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace PRAKTIKUM2_DESKTOP_NIS_NAMA
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=db_kopi_gudang;Uid=root;Password=;";
        string selectedId = "";

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilkanData("");
        }

        private void TampilkanData(string tampil)
        {
            dataGridView1.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM tb_bahan_baku";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int jumlah_kritis = 0;
                        int total_item = 0;

                        while (reader.Read())
                        {
                            int stok = Convert.ToInt32(reader["stok"]);
                            int harga_satuan = Convert.ToInt32(reader["harga_satuan"]);
                            int batas_minimum = Convert.ToInt32(reader["batas_minimum"]);

                            int no_baris = dataGridView1.Rows.Add(
                                reader["kode_bahan"].ToString(),
                                reader["nama_bahan"].ToString(),
                                reader["kategori"].ToString(),
                                reader["stok"].ToString(),
                                reader["satuan"].ToString(),
                                reader["harga_satuan"].ToString(),
                                reader["batas_minimum"].ToString()
                            );

                            total_item += stok * harga_satuan;
                            
                            if (stok <= batas_minimum)
                            {
                                dataGridView1.Rows[no_baris].DefaultCellStyle.BackColor = Color.FromArgb(255, 105, 105);
                                dataGridView1.Rows[no_baris].DefaultCellStyle.ForeColor = Color.White;

                                jumlah_kritis++;
                            }
                            else
                            {
                                dataGridView1.Rows[no_baris].DefaultCellStyle.BackColor = Color.FromArgb(3, 161, 252);
                                dataGridView1.Rows[no_baris].DefaultCellStyle.ForeColor = Color.White;
                            }
                            
                        }
                        label13.Text = jumlah_kritis.ToString();
                        label11.Text = total_item.ToString("n");

                    }
                }
            }
        }
        private void BersihkanInput()
        {
            txtBoxKodeBahan.Clear();
            txtBoxNamaBahan.Clear();
            cmbBoxKategori.SelectedIndex = -1;
            txtBoxStok.Clear();
            txtBoxSatuan.Clear();
            txtBoxHargaSatuan.Clear();
            txtBoxBatasMinimum.Clear();
            txtBoxKodeBahan.Focus();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            string kode_bahan = txtBoxKodeBahan.Text;
            string nama_bahan = txtBoxNamaBahan.Text;
            string kategori = cmbBoxKategori.Text;
            string stok = txtBoxStok.Text;
            string satuan = txtBoxSatuan.Text;
            string harga_satuan = txtBoxHargaSatuan.Text;
            string batas_minimum = txtBoxBatasMinimum.Text;

            if (string.IsNullOrWhiteSpace(kode_bahan) || string.IsNullOrWhiteSpace(nama_bahan) || string.IsNullOrWhiteSpace(kategori) || string.IsNullOrWhiteSpace(stok) || string.IsNullOrWhiteSpace(satuan) || string.IsNullOrWhiteSpace(harga_satuan) || string.IsNullOrWhiteSpace(batas_minimum))
            {
                MessageBox.Show("Semua field wajib diisi !");
                return;
            }

            if (stok == "0" || harga_satuan == "0")
            {
                MessageBox.Show("Input stok atau harga tidak valid !");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO tb_bahan_baku (kode_bahan, nama_bahan, kategori, stok, satuan, harga_satuan, batas_minimum) VALUES (@kode_bahan, @nama_bahan, @kategori, @stok, @satuan, @harga_satuan, @batas_minimum)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode_bahan", kode_bahan);
                        cmd.Parameters.AddWithValue("@nama_bahan", nama_bahan);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@satuan", satuan);
                        cmd.Parameters.AddWithValue("@harga_satuan", harga_satuan);
                        cmd.Parameters.AddWithValue("@batas_minimum", batas_minimum);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data bahan baku berhasil disimpan !");

                        TampilkanData("");

                        BersihkanInput();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("kode_bahan"))
                {
                    MessageBox.Show("Kode bahan sudah digunakan !");
                    return;
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan pada " + ex.Message);
                    return;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedId = row.Cells[0].Value.ToString();
            txtBoxKodeBahan.Text = row.Cells[0].Value.ToString();
            txtBoxNamaBahan.Text = row.Cells[1].Value.ToString();
            cmbBoxKategori.Text = row.Cells[2].Value.ToString();
            txtBoxStok.Text = row.Cells[3].Value.ToString();
            txtBoxSatuan.Text = row.Cells[4].Value.ToString();
            txtBoxHargaSatuan.Text = row.Cells[5].Value.ToString();
            txtBoxBatasMinimum.Text = row.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string kode_bahan = txtBoxKodeBahan.Text;
            string nama_bahan = txtBoxNamaBahan.Text;
            string kategori = cmbBoxKategori.Text;
            string stok = txtBoxStok.Text;
            string satuan = txtBoxSatuan.Text;
            string harga_satuan = txtBoxHargaSatuan.Text;
            string batas_minimum = txtBoxBatasMinimum.Text;

            if (selectedId == "")
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu !");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE tb_bahan_baku SET kode_bahan = @kode_bahan, nama_bahan = @nama_bahan, kategori = @kategori, stok = @stok, satuan = @satuan, harga_satuan = @harga_satuan, batas_minimum = @batas_minimum WHERE kode_bahan = @kode_bahan_lama";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode_bahan_lama", selectedId);
                        cmd.Parameters.AddWithValue("@kode_bahan", kode_bahan);
                        cmd.Parameters.AddWithValue("@nama_bahan", nama_bahan);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@satuan", satuan);
                        cmd.Parameters.AddWithValue("@harga_satuan", harga_satuan);
                        cmd.Parameters.AddWithValue("@batas_minimum", batas_minimum);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data bahan baku berhasil di Update disimpan !");

                        TampilkanData("");

                        BersihkanInput();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan pada " + ex.Message);
                return;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu !");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM tb_bahan_baku WHERE kode_bahan = @kode_bahan_lama";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode_bahan_lama", selectedId);

                        DialogResult pilihan = MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu !", "Hapus", MessageBoxButtons.YesNo);

                        if (pilihan == DialogResult.Yes)
                        {
                            MessageBox.Show("Data berhasil dihapus !");

                            cmd.ExecuteNonQuery();

                            TampilkanData("");

                            BersihkanInput();
                        }
                        else if (pilihan == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan pada " + ex.Message);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BersihkanInput();
        }
    }
}
