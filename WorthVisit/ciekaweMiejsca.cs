using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorthVisit
{
    class ciekaweMiejsca
    {
        public string NazwaMiejsca { get; set; }
        public string Kraj { get; set; }
        public string Opis { get; set; }
        public byte[] Zdjecie { get; set; }

        public ciekaweMiejsca() { }

        public ciekaweMiejsca(string nazwaMiejsca, string kraj, string opis, byte[] zdjecie)
        {
            this.NazwaMiejsca = nazwaMiejsca;
            this.Kraj = kraj;
            this.Opis = opis;
            this.Zdjecie = zdjecie;
        }
    }
}
