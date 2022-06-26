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
    public partial class Asupan_Manajemen : UserControl
    {
        public Asupan_Manajemen()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Asupan asupan = new Asupan(namaCtrl.Text.Trim(), kategoriCtrl.Text.Trim(), Convert.ToInt32(kaloriCtrl.Text.Trim()), ukuranCtrl.Text.Trim());
            DBMedStory.AddAsupan(asupan);
        }
    }
}
