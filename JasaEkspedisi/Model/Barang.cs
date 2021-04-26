using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasaEkspedisi.Model
{
    class Barang
    {
        string namaBarang, kodeBarang, jenisBarang;
        int beratBarang;

        public Barang()
        {
            NamaBarang = namaBarang;
            KodeBarang = kodeBarang;
            JenisBarang = jenisBarang;
            BeratBarang = beratBarang;
        }

        public string NamaBarang { get => namaBarang; set => namaBarang = value; }
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string JenisBarang { get => jenisBarang; set => jenisBarang = value; }
        public int BeratBarang { get => beratBarang; set => beratBarang = value; }
    }
}
