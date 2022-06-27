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
    public partial class Darurat_Manajemen : UserControl
    {
        public Darurat_Manajemen()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Faskes fks = new Faskes(namaFaskesCtrl.Text.Trim(), float.Parse(ratingCtrl.Text.Trim()), alamatCtrl.Text.Trim(), kontakCtrl.Text.Trim(), fasilitasCtrl.Text.Trim(), poliklinikCtrl.Text.Trim(), kordinatCtrl.Text.Trim());
            DBMedStory.AddFasilitasKesehatan(fks);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sunday = "";
            String monday = "";
            String tuesday = "";
            String wednesday = "";
            String thursday = "";
            String friday = "";
            String saturday = "";

            if (suDayCtrl.Checked)
            {
                sunday = "Su, ";
            }
            if (moDayCtrl.Checked)
            {
                monday = "Mo, ";
            }
            if (tusDayCtrl.Checked)
            {
                tuesday = "Tu, ";
            }
            if (weDayCtrl.Checked)
            {
                wednesday = "We, ";
            }
            if (thuDayCtrl.Checked)
            {
                thursday = "Th, ";
            }
            if (frDayCtrl.Checked)
            {
                friday = "Fr, ";
            }
            if (satDayCtrl.Checked)
            {
                saturday = "St, ";
            }

            String jadwal = monday + tuesday + wednesday + thursday + friday + saturday + sunday;

            Dokter dkt = new Dokter(namaDokterCtrl.Text.Trim(), spesialisCtrl.Text.Trim(), DateTime.Parse(jamMulaiCtrl.Text.Trim()).ToString("HH:mm"), DateTime.Parse(jamSelesaiCtrl.Text.Trim()).ToString("HH:mm"), jadwal, lokasiCtrl.Text.Trim());
            DBMedStory.AddDokterPraktek(dkt);
        }
    }
}
