using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Letovi_RezervacijaVM
    {

        public class Rows
        {
            public int LetID { get; set; }
            public int PolazisteID { get; set; }
            public int OdredisteID { get; set; }
            public string BrojLeta { get; set; }
            public string polaziste { get; set; }
            public string odrediste { get; set; }
            public string DatumPolaska { get; set; }
            public string VrijemePolaska { get; set; }
            public string DatumDolaska{ get; set; }
            public string VrijemeDolaska { get; set; }
            public double? CijenaBussOdrasli { get; set; }
            public double? CijenaBussDjeca { get; set; }
            public double CijenaEcoDjeca { get; set; }
            public double CijenaEcoOdrasli { get; set; }
            public int BrojSlobodnihEkonomska { get; set; }
            public int BrojSlobodnihBussiness { get; set; }
        }

        public List<Rows> podaci { get; set; }

    }
}