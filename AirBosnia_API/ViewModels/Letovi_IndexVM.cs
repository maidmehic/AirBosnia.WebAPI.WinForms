using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Letovi_IndexVM
    {
        public class Rows
        {
            public int LetID { get; set; }
            public int PolazisteID { get; set; }
            public int OdredisteID { get; set; }
            public int ZaposlenikID { get; set; }
            public string BrojLeta { get; set; }
            public string polaziste { get; set; }
            public string odrediste { get; set; }
            public string avion { get; set; }
            public int AvionID { get; set; }
            public DateTime DatumVrijemePolaska { get; set; }
            public DateTime DatumVrijemeDolaska { get; set; }
            public bool StatusLeta { get; set; }
            public double? CijenaBussOdrasli { get; set; }
            public double? CijenaBussDjeca { get; set; }
            public double CijenaEcoDjeca { get; set; }
            public double CijenaEcoOdrasli { get; set; }

        }

        public List<Rows> podaci { get; set; }
    }
}