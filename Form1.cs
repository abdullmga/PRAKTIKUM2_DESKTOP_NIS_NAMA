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

namespace PRAKTIKUM2_DESKTOP_NIS_NAMA
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=db_kopi_gudang;Uid=root;Password=;";
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
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["kode_bahan"].ToString(),
                                reader["nama_bahan"].ToString(), 
                                reader["kategori"].ToString(), 
                                reader["stok"].ToString(), 
                                reader["satuan"].ToString(), 
                                reader["harga_satuan"].ToString(), 
                                reader["batas_minimum"].ToString());
                        }
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
            
            txtBoxKodeBahan.Text = row.Cells[0].Value.ToString();
            txtBoxNamaBahan.Text = row.Cells[1].Value.ToString();
            cmbBoxKategori.Text = row.Cells[2].Value.ToString();
            txtBoxStok.Text = row.Cells[3].Value.ToString();
            txtBoxSatuan.Text = row.Cells[4].Value.ToString();
            txtBoxHargaSatuan.Text = row.Cells[5].Value.ToString();
            txtBoxBatasMinimum.Text = row.Cells[6].Value.ToString();
        }
    }
}
