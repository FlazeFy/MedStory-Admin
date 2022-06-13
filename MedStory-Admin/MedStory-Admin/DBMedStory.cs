using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedStory_Admin
{
    class DBMedStory
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=medstory";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void ReadUser(String query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static void AddPenyakit(Penyakit pykt)
        {
            string sql = "INSERT INTO smartdoc VALUES (NULL, @Nama_penyakit, @Penanganan, @Rasio, @Level, @Pencegahan)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nama_penyakit", MySqlDbType.VarChar).Value = pykt.Nama;
            cmd.Parameters.Add("@Penanganan", MySqlDbType.VarChar).Value = pykt.Penanganan;
            cmd.Parameters.Add("@Rasio", MySqlDbType.VarChar).Value = pykt.Rasio;
            cmd.Parameters.Add("@Level", MySqlDbType.Int32).Value = pykt.Level;
            cmd.Parameters.Add("@Pencegahan", MySqlDbType.VarChar).Value = pykt.Penanganan;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahakan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Input gagal ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            con.Close();
        }
        public static void AddGejala(Gejala gjl)
        {
            string sql = "INSERT INTO gejala VALUES (NULL, @Nama_gejala)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nama_gejala", MySqlDbType.VarChar).Value = gjl.Nama;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahakan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Input gagal ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            con.Close();
        }
        public static void AddDiskusi(Diskusi dis)
        {
            string sql = "INSERT INTO diskusi VALUES (NULL, @Nama_Pengguna, @Pertanyaan, @Kategori, @View, @Up, @ImageURL, @Datetime)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nama_Pengguna", MySqlDbType.VarChar).Value = "Admin";
            cmd.Parameters.Add("@Pertanyaan", MySqlDbType.VarChar).Value = dis.Pertanyaan;
            cmd.Parameters.Add("@Kategori", MySqlDbType.VarChar).Value = dis.Kategori;
            cmd.Parameters.Add("@View", MySqlDbType.VarChar).Value = 0;
            cmd.Parameters.Add("@Up", MySqlDbType.VarChar).Value = 0;
            cmd.Parameters.Add("@ImageURL", MySqlDbType.VarChar).Value = "null"; //For now until upload file feature has been created
            cmd.Parameters.Add("@Datetime", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahakan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Input gagal ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            con.Close();
        }
    }
}
