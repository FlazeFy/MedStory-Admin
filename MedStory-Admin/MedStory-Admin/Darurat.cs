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
    class Dokter
    {
        public string NamaDokter { get; set; }
        public string Spesialis { get; set; }
        public string JamMulai { get; set; }
        public string JamSelesai { get; set; }
        public string HariPraktik { get; set; }
        public string Lokasi { get; set; }

        public Dokter(string namadokter, string spesialis, string jammulai, string jamselesai, string haripraktik, string lokasi)
        {
            NamaDokter = namadokter;
            Spesialis = spesialis;
            JamMulai = jammulai;
            JamSelesai = jamselesai;
            HariPraktik = haripraktik;
            Lokasi = lokasi;
        }
    }
}
