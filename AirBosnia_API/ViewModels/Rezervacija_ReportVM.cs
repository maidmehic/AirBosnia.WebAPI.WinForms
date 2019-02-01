using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Rezervacija_ReportVM
    {
        public class Rows
        {
            public string ImePrezime { get; set; }
            public string SpolTip { get; set; }
            public string DatumRodenja { get; set; }
            public string TipDokumenta { get; set; }
            public string BrojDokumenta { get; set; }
            public string DatumRezervacije { get; set; }
        }
        public List<Rows> podaci{ get; set; }
        public string DatumLeta { get; set; }
        public string VrijemePolaska { get; set; }
        public string Polaziste { get; set; }
        public string BrojLeta { get; set; }
        public string Odrediste { get; set; }
    }
}