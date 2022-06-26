using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedStory_Admin
{
    class Asupan
    {
        public string Nama { get; set; }
        public string Kategori { get; set; }
        public int Kalori { get; set; }
        public string Ukuran { get; set; }

        public Asupan(string nama, string kategori, int kalori, string ukuran)
        {
            Nama = nama;
            Kategori = kategori;
            Kalori = kalori;
            Ukuran = ukuran;
        }
    }
}
