using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedStory_Admin
{
    class Diskusi
    {
        public string Pertanyaan { get; set; }
        public string Kategori { get; set; }
        //public string ImageURL { get; set; }

        public Diskusi(string pertanyaan, string kategori /*, string imageurl*/)
        {
            Pertanyaan = pertanyaan;
            Kategori = kategori;
            //ImageURL = imageurl;
        }
    }
    class Balasan
    {
        public string Isi { get; set; }
        public int Id_Diskusi { get; set; }

        //public string ImageURL { get; set; }

        public Balasan(string isi, int id_diskusi /*, string imageurl*/)
        {
            Isi = isi;
            Id_Diskusi = id_diskusi;
            //ImageURL = imageurl;
        }
    }
}
