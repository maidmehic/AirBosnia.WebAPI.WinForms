using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Rezervacije_IndexVM
    {
        public class Rows
        {
            public int RezervacijaID { get; set; }
            public string ImePrezime { get; set; }
            public string DatumRodjenjaPutnika { get; set; }
            public string SpolTip { get; set; }
            public string TipDokumenta { get; set; }
            public string BrojDokumenta { get; set; }
            public string DatumRezervacije { get; set; }
            public string Sjediste { get; set; }
            public string DatumLeta { get; set; }
            public string BrojLeta { get; set; }
            public string RutaPutovanja { get; set; }
        }
        public List<Rows> podaci  { get; set; }
    }
}