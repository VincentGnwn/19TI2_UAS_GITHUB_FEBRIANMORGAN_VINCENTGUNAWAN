using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasaEkspedisi.Model
{
    class Invoice
    {
        string namaBarang, jenisBarang, namaPenerima, alamatPenerima, namaKurir, nomorInvoice;
        int ongkosKirim, beratBarang;

        public Invoice()
        {
            NamaBarang = namaBarang;
            JenisBarang = jenisBarang;
            BeratBarang = beratBarang;
            NamaPenerima = namaPenerima;
            AlamatPenerima = alamatPenerima;
            NamaKurir = namaKurir;
            NomorInvoice = nomorInvoice;
            OngkosKirim = ongkosKirim;
        }


        public string NomorInvoice { get => nomorInvoice; set => nomorInvoice = value; }
        public int OngkosKirim { get => ongkosKirim; set => ongkosKirim = value; }
        public string NamaBarang { get => namaBarang; set => namaBarang = value; }
        public string JenisBarang { get => jenisBarang; set => jenisBarang = value; }
        public string NamaPenerima { get => namaPenerima; set => namaPenerima = value; }
        public string AlamatPenerima { get => alamatPenerima; set => alamatPenerima = value; }
        public string NamaKurir { get => namaKurir; set => namaKurir = value; }
        public int BeratBarang { get => beratBarang; set => beratBarang = value; }
    }
}
