using AirBosnia_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBosnia_UI
{
   public class Global
    {
        public static Zaposlenik logirani{ get; set; }


        public const string AvionRoute = "api/Avion";
        public const string GradRoute = "api/Grad";       
        public const string KorisnickiNalogRoute = "api/KorisnickiNalog";
        public const string KorisnikRoute = "api/Korisnik";
        public const string LetRoute = "api/Let";
        public const string PosadaLetaRoute = "api/PosadaLeta";
        public const string PosebnaPonudaRoute = "api/PosebnaPonuda";
        public const string RezervacijaRoute = "api/Rezervacija";
        public const string SjedisteRoute = "api/Sjediste";
        public const string TipZaposlenjaRoute = "api/TipZaposlenja";
        public const string ZaposlenikRoute = "api/Zaposlenik";
    }
}
