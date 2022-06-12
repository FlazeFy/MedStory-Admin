using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedStory_Admin
{
    class Penyakit
    {
        public string Nama { get; set; }
        public int Level { get; set; }
        public string Penanganan { get; set; }
        public string Pencegahan { get; set; }
        public string Rasio { get; set; }

        public Penyakit(string nama, int level, string penanganan, string pencegahan, string rasio)
        {
            Nama = nama;
            Level = level;
            Penanganan = penanganan;
            Pencegahan = pencegahan;
            Rasio = rasio;
        }
    }
    class Gejala
    {
        public string Nama { get; set; }

        public Gejala(string nama)
        {
            Nama = nama;
        }
    }
}
