using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class Zaposlenici_IndexVM
    {
        public class Rows
        {
            public int ZaposlenikID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string BrojUgovora { get; set; }
            public string Spol { get; set; }
            public string DatumRodenja { get; set; }
            public bool Aktivan { get; set; }
            public string Pozicija { get; set; }
            public string Grad { get; set; }
        }

        public List<Rows>podaci{ get; set; }
    }
}