using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasaEkspedisi.Model
{
    class Penerima
    {
        string namaPenerima, alamatPenerima, kodePosPenerima, noTelp;

        public Penerima()
        {
            NamaPenerima = namaPenerima;
            AlamatPenerima = alamatPenerima;
            KodePosPenerima = kodePosPenerima;
            NoTelp = noTelp;
        }

        public string NamaPenerima { get => namaPenerima; set => namaPenerima = value; }
        public string AlamatPenerima { get => alamatPenerima; set => alamatPenerima = value; }
        public string KodePosPenerima { get => kodePosPenerima; set => kodePosPenerima = value; }
        public string NoTelp { get => noTelp; set => noTelp = value; }
    }
}
