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
    }
}
