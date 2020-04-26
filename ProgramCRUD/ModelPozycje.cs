using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCRUD
{
    class ModelPozycje
    {
        public int Poz_ID { get; set; }
        public int Poz_NagID { get; set; }
        public int Poz_Liczba { get; set; }
        public string Poz_NazwaArtykulu { get; set; }
        public decimal Poz_CenaNetto { get; set; }
        public decimal Poz_CenaBrutto { get; set; }

        public ModelPozycje(string poz_NagID, string poz_Liczba, string poz_NazwaArtykulu, string poz_CenaNetto, string poz_CenaBrutto)
        {
            this.Poz_NagID = int.Parse(poz_NagID);
            this.Poz_Liczba = int.Parse(poz_Liczba);
            this.Poz_NazwaArtykulu = poz_NazwaArtykulu;
            this.Poz_CenaNetto = decimal.Parse(poz_CenaNetto);
            this.Poz_CenaBrutto = decimal.Parse(poz_CenaBrutto);
        }

        public ModelPozycje(string poz_Liczba, string poz_NazwaArtykulu, string poz_CenaNetto, string poz_CenaBrutto)
        {
            this.Poz_Liczba = int.Parse(poz_Liczba);
            this.Poz_NazwaArtykulu = poz_NazwaArtykulu;
            this.Poz_CenaNetto = decimal.Parse(poz_CenaNetto);
            this.Poz_CenaBrutto = decimal.Parse(poz_CenaBrutto);
        }
    }

}
