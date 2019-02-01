using AirBosnia_API.Models;
using AirBosnia_API.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirBosnia_API.Controllers
{
    public class RecommenderController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();



        public class Rows
        {
            public int polazisteID;
            public int odredisteID;
            public int brojac = 1;
        }

        [HttpGet]
        [Route("api/Recommender/RezervacijeKorisnika/{korisnikID}")]
        public List<Rows> RezervacijeKorisnika(int korisnikID)
        {
            List<Rezervacija> korisnikoveRezervacije = db.Rezervacija.Include(x=>x.Let)
                .Where(x => x.KorisnikID == korisnikID).ToList();

            List<Rows> podaci = new List<Rows>();
            foreach (Rezervacija r in korisnikoveRezervacije.ToList())
            {
                bool postoji = false;
                if (podaci.Count == 0)
                {
                    podaci.Add(new Rows
                    {
                        polazisteID = r.Let.PolazisteID,
                        odredisteID = r.Let.OdredisteID,
                        brojac = 1
                    });
                }
                else
                {
                    foreach (Rows rows in podaci.ToList())
                    {
                        if (r.Let.PolazisteID == rows.polazisteID && r.Let.OdredisteID == rows.odredisteID)
                        {
                            rows.brojac++;
                            postoji = true;
                        }
                    }

                    if (postoji == false)
                    {
                        podaci.Add(new Rows
                        {
                            polazisteID = r.Let.PolazisteID,
                            odredisteID = r.Let.OdredisteID,
                            brojac = 1
                        });
                    }
                }
               
            }

            return podaci.OrderByDescending(x=>x.brojac).ToList();

        }

        [HttpGet]
        [Route("api/Recommender/SearchRecommendedLet/{korisnikID}")]
        public IHttpActionResult SearchRecommendedLet(int korisnikID)
        {
            List<Rows> dosadasnjeRezervacije = RezervacijeKorisnika(korisnikID);

            Letovi_RezervacijaVM temp = new Letovi_RezervacijaVM();

            List<Let> letovi = new List<Let>();
            foreach (Rows rows in dosadasnjeRezervacije.Take(5).ToList())
            {
                letovi.AddRange(db.Let.Include(x => x.Grad).Include(x => x.Grad1).
                          Where(x => x.isPosebnaPonuda == false && x.PolazisteID == rows.polazisteID && x.OdredisteID == rows.odredisteID &&
                          x.DatumVrijemePolaska > DateTime.Now && x.StatusLeta == false).
                          ToList().Take(5));
            }


            temp.podaci = letovi.OrderBy(x=>x.DatumVrijemePolaska).Select(x => new Letovi_RezervacijaVM.Rows
            {
                LetID = x.LetID,
                PolazisteID = x.PolazisteID,
                OdredisteID = x.OdredisteID,
                BrojLeta = x.BrojLeta,

                DatumPolaska = x.DatumVrijemePolaska.ToString("d MMM, yyyy"),
                DatumDolaska = x.DatumVrijemeDolaska.ToString("d MMM, yyyy"),

                VrijemePolaska = x.DatumVrijemePolaska.ToString("HH:mm"),
                VrijemeDolaska = x.DatumVrijemeDolaska.ToString("HH:mm"),

                CijenaBussOdrasli = x.CijenaBussOdrasli,
                CijenaBussDjeca = x.CijenaBussDjeca,
                CijenaEcoDjeca = x.CijenaEcoDjeca,
                CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                BrojSlobodnihBussiness = Convert.ToInt32(db.Sjediste.Where(p => p.LetID == x.LetID && p.isBussiness == true && p.isZauzeto == false).Count()),
                BrojSlobodnihEkonomska = Convert.ToInt32(db.Sjediste.Where(p => p.LetID == x.LetID && p.isBussiness == false && p.isZauzeto == false).Count())
            }).ToList();

            Letovi_RezervacijaVM Model = new Letovi_RezervacijaVM();
            Model.podaci = new List<Letovi_RezervacijaVM.Rows>();
            Model.podaci = temp.podaci.Where(x => x.BrojSlobodnihBussiness > 0 || x.BrojSlobodnihEkonomska > 0).ToList();

            return Ok(Model);
        }
    }
}
