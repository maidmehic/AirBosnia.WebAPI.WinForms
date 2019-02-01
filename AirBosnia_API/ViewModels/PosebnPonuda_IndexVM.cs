using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBosnia_API.ViewModels
{
    public class PosebnPonuda_IndexVM
    {
        public class Rows
        {
            public string DatumVrijemePolaska { get; set; }
            public int PosebnaPonudaID { get; set; }
            public string Polaziste { get; set; }
            public string Odrediste { get; set; }
            public string CijenaBezKarte { get; set; }
            public string Smjestaj { get; set; }
            public string Napomena { get; set; }
            public string BrojDana { get; set; }
            public string Evidentirao { get; set; }
            public string BrojLeta { get; set; }
        }
        public List<Rows>ponude{ get; set; }
    }
}