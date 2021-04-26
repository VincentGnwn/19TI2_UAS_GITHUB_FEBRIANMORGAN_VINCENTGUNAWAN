using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasaEkspedisi.Model
{
    class Kurir
    {
        string namaKurir, genderKurir, noKtp;
        int umurKurir;

        public Kurir() 
        {
            NamaKurir = namaKurir;
            UmurKurir = umurKurir;
            GenderKurir = genderKurir;
            NoKtp = noKtp;
        }

        public int UmurKurir { get => umurKurir; set => umurKurir = value; }
        public string NamaKurir { get => namaKurir; set => namaKurir = value; }
        public string GenderKurir { get => genderKurir; set => genderKurir = value; }
        public string NoKtp { get => noKtp; set => noKtp = value; }
    }
}
