using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.Models
{
    public partial class PosadaLeta
    {
        public string Ime{ get; set; }
        public string Prezime{ get; set; }
        public string DatumRodenja{ get; set; }
        public string Pozicija{ get; set; }
        public string Telefon{ get; set; }
    }
}