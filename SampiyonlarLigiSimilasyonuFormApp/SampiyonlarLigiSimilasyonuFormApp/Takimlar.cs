using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiSimilasyonuFormApp
{
    class Takimlar
    {
        public string TakimAdi { get; set; }
        public string TakimUlkesi { get; set; }

        public Takimlar(string isim, string ulke)
        {
            TakimAdi = isim;
            TakimUlkesi = ulke;

        }

        public string TeamName
        {
            get
            {
                return TakimAdi;
            }
            set
            {
                TakimAdi = value;
            }

        }
        public string TeamCountry
        {
            get
            {
                return TakimUlkesi;
            }
            set
            {
                TakimUlkesi = value;
            }

        }

        public override string ToString()
        {
            return TakimAdi + " - " + TakimUlkesi;
        }

    }
}
