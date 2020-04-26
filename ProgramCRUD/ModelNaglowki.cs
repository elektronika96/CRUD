using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCRUD
{
    public class ModelNaglowki
    {
        public int Nag_ID { get; set; }
        public DateTime Nag_Data { get; set; }
        public int Nag_NumerKlienta { get; set; }
        public string Nag_Nazwa { get; set; }
        public decimal Nag_CenaNetto { get; set; }
        public decimal Nag_CenaBrutto { get; set; }
    }
}
