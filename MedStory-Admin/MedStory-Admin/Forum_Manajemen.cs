using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedStory_Admin
{
    public partial class Forum_Manajemen : UserControl
    {
        int pass_idBalasan = 0;
        public Forum_Manajemen()
        {
            InitializeComponent();
        }

        private void Forum_Manajemen_Load(object sender, EventArgs e)
        {

        }
        public void displayDiskusi()
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi", dataGridView2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Diskusi dis = new Diskusi(pertanyaanCtrl.Text.Trim(), kategoriCtrl.Text.Trim());
            DBMedStory.AddDiskusi(dis);
            displayDiskusi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pass_idBalasan != 0)
            {
                Balasan bls = new Balasan(isiBalasanCtrl.Text.Trim(), Convert.ToInt32(pass_idBalasan));
                DBMedStory.AddBalasan(bls);
            } 
            else
            {
                MessageBox.Show("Anda belum memilih pertanyaan yang akan dibalas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi WHERE namaPengguna LIKE '%" + textBox1.Text + "%' OR pertanyaan LIKE '%" + textBox1.Text + "%'", dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (e.ColumnIndex == 1)
                {
                    pass_idBalasan = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    MessageBox.Show("Id berhasil dipilih (" + pass_idBalasan.ToString() + ")", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pilih kolom yang valid (ID)!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
