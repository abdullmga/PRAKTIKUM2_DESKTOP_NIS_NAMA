using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
