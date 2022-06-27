using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedStory_Admin
{
    class Faskes
    {
        public string NamaFaskes { get; set; }
        public float Rating { get; set; }
        public string Alamat { get; set; }
        public string Kontak { get; set; }
        public string Fasilitas { get; set; }
        public string Poliklinik { get; set; }
        public string Kordinat { get; set; }

        public Faskes(string namafaskes, float rating, string alamat, string kontak, string fasilitas, string poliklinik, string kordinat)
        {
            NamaFaskes = namafaskes;
            Rating = rating;
            Alamat = alamat;
            Kontak = kontak;
            Fasilitas = fasilitas;
            Poliklinik = poliklinik;
            Kordinat = kordinat;
        }
    }
}
