using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Korisnikove_RezervacijeVM
    {
        public class Rows
        {
            public int LetID { get; set; }
            public string BrojLeta { get; set; }
            public string polaziste { get; set; }
            public string odrediste { get; set; }
            public string DatumPolaska { get; set; }
            public string VrijemePolaska { get; set; }
            public string DatumDolaska { get; set; }
            public string VrijemeDolaska { get; set; }
            public int RezervacijaID { get; set; }
        }

        public List<Rows> podaci { get; set; }
    }
}