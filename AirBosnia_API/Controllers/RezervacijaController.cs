using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AirBosnia_API.Models;
using AirBosnia_API.ViewModels;

namespace AirBosnia_API.Controllers
{
    public class RezervacijaController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        [HttpGet]
        [Route("api/Rezervacija/SearchRezervacijeByLetID/{letId}")]
        public IHttpActionResult SearchRezervacijeByLetID(int letId)
        {
            Rezervacija_ReportVM Model = new Rezervacija_ReportVM();

            List<Rezervacija> rezervacije = db.Rezervacija.Include(x=>x.Let).Include(x=>x.Let.Grad).Include(x => x.Let.Grad1)
                .Where(x => x.LetPolazakID == letId).ToList();


            Model.podaci = rezervacije.Select(x => new Rezervacija_ReportVM.Rows
            {
                ImePrezime = x.ImePutnika + " " + x.PrezimePutnika,
                DatumRodenja = x.DatumRodjenjaPutnika.ToString("d MMM, yyyy"),
                SpolTip = x.Spol+" / "+x.TipPutnika,
                TipDokumenta = x.TipDokumenta,
                BrojDokumenta = x.BrojDokumenta,
                DatumRezervacije=x.DatumRezervacije.ToString("d MMM, yyyy HH:mm")
            }).ToList();

            Model.DatumLeta = rezervacije.FirstOrDefault().Let.DatumVrijemePolaska.ToString("d MMM, yyyy");
            Model.VrijemePolaska = rezervacije.FirstOrDefault().Let.DatumVrijemePolaska.ToString("HH:mm");
            Model.Polaziste = rezervacije.FirstOrDefault().Let.Grad1.Naziv + " (" + rezervacije.FirstOrDefault().Let.Grad1.Oznaka + ")";
            Model.Odrediste = rezervacije.FirstOrDefault().Let.Grad.Naziv + " (" + rezervacije.FirstOrDefault().Let.Grad.Oznaka + ")";
            Model.BrojLeta = rezervacije.FirstOrDefault().Let.BrojLeta;

            if (Model.podaci.Count == 0)
            {
                return NotFound();
            }

            return Ok(Model);
        }


        [HttpGet]
        [Route("api/Rezervacija/SearchLetByLogiraniKorisnik/{korisnikID}")]
        public IHttpActionResult SearchLetByLogiraniKorisnik(int korisnikID)
        {
            Korisnikove_RezervacijeVM Model = new Korisnikove_RezervacijeVM();

            List<Rezervacija> rezervacije = db.Rezervacija.Where(x => x.KorisnikID == korisnikID).
                Include(x => x.Let).
                Include(x => x.Let.Grad).
                Include(x => x.Let.Grad1).
                OrderByDescending(x => x.DatumRezervacije).ToList();

            Model.podaci = rezervacije.Select(x => new Korisnikove_RezervacijeVM.Rows
            {
                LetID = x.Let.LetID,
                BrojLeta = x.Let.BrojLeta,

                DatumPolaska = x.Let.DatumVrijemePolaska.ToString("d MMM, yyyy"),
                DatumDolaska = x.Let.DatumVrijemeDolaska.ToString("d MMM, yyyy"),

                VrijemePolaska = x.Let.DatumVrijemePolaska.ToString("HH:mm"),
                VrijemeDolaska = x.Let.DatumVrijemeDolaska.ToString("HH:mm"),
                
                polaziste = x.Let.Grad1.Naziv + " " + x.Let.Grad1.Oznaka,
                odrediste = x.Let.Grad.Naziv + " " + x.Let.Grad.Oznaka,
                RezervacijaID=x.RezervacijaID
            }) .ToList();

            return Ok(Model);
        }

        [HttpGet]
        [Route("api/Rezervacija/SearchRezervacijeDanasnjiDan/{imePrezime?}")]
        public IHttpActionResult SearchRezervacijeDanasnjiDan(string imePrezime = "")
        {
            if (imePrezime == "")
            {
                Rezervacije_IndexVM Model = new Rezervacije_IndexVM();
                List<Rezervacija> rezervacije = db.Rezervacija.
                    OrderByDescending(x => x.DatumRezervacije).Where(x => DbFunctions.TruncateTime(x.DatumRezervacije)== DbFunctions.TruncateTime(DateTime.Now)).
                    Include(x => x.Sjediste).
                    Include(x => x.Let).
                    Include(x => x.Let.Grad).
                    Include(x => x.Let.Grad1).
                    ToList();

                Model.podaci = rezervacije.Select(x => new Rezervacije_IndexVM.Rows
                {
                    RezervacijaID = x.RezervacijaID,
                    ImePrezime = x.ImePutnika + " " + x.PrezimePutnika,
                    DatumRodjenjaPutnika = x.DatumRodjenjaPutnika.ToString("d MMM, yyyy"),
                    SpolTip = x.Spol + " / " + x.TipPutnika,
                    TipDokumenta = x.TipDokumenta,
                    BrojDokumenta = x.BrojDokumenta,
                    DatumRezervacije = x.DatumRezervacije.ToString("d MMM, yyyy HH:mm"),
                    Sjediste = x.Sjediste.Oznaka,
                    DatumLeta = x.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm"),
                    BrojLeta = x.Let.BrojLeta,
                    RutaPutovanja = x.Let.Grad1.Naziv + " (" + x.Let.Grad1.Oznaka + ") " + x.Let.Grad.Naziv + " (" + x.Let.Grad.Oznaka + ")"

                }).ToList();

                return Ok(Model);
            }
            else
            {
                Rezervacije_IndexVM Model = new Rezervacije_IndexVM();
                List<Rezervacija> rezervacije = db.Rezervacija.
                    OrderByDescending(x => x.DatumRezervacije).
                    Where(x => ((x.ImePutnika.ToLower() + " " + x.PrezimePutnika.ToLower()).StartsWith(imePrezime.ToLower()) || (x.PrezimePutnika.ToLower() + " " + x.ImePutnika.ToLower()).StartsWith(imePrezime.ToLower())) && DbFunctions.TruncateTime(x.DatumRezervacije) == DbFunctions.TruncateTime(DateTime.Now)).
                    Include(x => x.Sjediste).
                    Include(x => x.Let).
                    Include(x => x.Let.Grad).
                    Include(x => x.Let.Grad1).
                    ToList();

                Model.podaci = rezervacije.Select(x => new Rezervacije_IndexVM.Rows
                {
                    RezervacijaID = x.RezervacijaID,
                    ImePrezime = x.ImePutnika + " " + x.PrezimePutnika,
                    DatumRodjenjaPutnika = x.DatumRodjenjaPutnika.ToString("d MMM, yyyy"),
                    SpolTip = x.Spol + " / " + x.TipPutnika,
                    TipDokumenta = x.TipDokumenta,
                    BrojDokumenta = x.BrojDokumenta,
                    DatumRezervacije = x.DatumRezervacije.ToString("d MMM, yyyy HH:mm"),
                    Sjediste = x.Sjediste.Oznaka,
                    DatumLeta = x.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm"),
                    BrojLeta = x.Let.BrojLeta,
                    RutaPutovanja = x.Let.Grad1.Naziv + " (" + x.Let.Grad1.Oznaka + ") " + x.Let.Grad.Naziv + " (" + x.Let.Grad.Oznaka + ")"

                }).ToList();

                return Ok(Model);
            }
        }

        [HttpGet]
        [Route("api/Rezervacija/SearchRezervacijeByPutnik/{imePrezime?}")]
        public IHttpActionResult SearchRezervacijeByPutnik(string imePrezime="")
        {
            if (imePrezime == "")
            {
                Rezervacije_IndexVM Model = new Rezervacije_IndexVM();
                List<Rezervacija> rezervacije = db.Rezervacija.
                    OrderByDescending(x => x.DatumRezervacije).
                    Include(x => x.Sjediste).
                    Include(x => x.Let).
                    Include(x => x.Let.Grad).
                    Include(x => x.Let.Grad1).
                    Take(60).
                    ToList();

                Model.podaci = rezervacije.Select(x => new Rezervacije_IndexVM.Rows
                {
                    RezervacijaID = x.RezervacijaID,
                    ImePrezime = x.ImePutnika + " " + x.PrezimePutnika,
                    DatumRodjenjaPutnika = x.DatumRodjenjaPutnika.ToString("d MMM, yyyy"),
                    SpolTip = x.Spol + " / " + x.TipPutnika,
                    TipDokumenta = x.TipDokumenta,
                    BrojDokumenta = x.BrojDokumenta,
                    DatumRezervacije = x.DatumRezervacije.ToString("d MMM, yyyy HH:mm"),
                    Sjediste = x.Sjediste.Oznaka,
                    DatumLeta = x.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm"),
                    BrojLeta = x.Let.BrojLeta,
                    RutaPutovanja = x.Let.Grad1.Naziv + " (" + x.Let.Grad1.Oznaka + ") " + x.Let.Grad.Naziv + " (" + x.Let.Grad.Oznaka + ")"

                }).ToList();

                return Ok(Model);
            }
            else
            {
                Rezervacije_IndexVM Model = new Rezervacije_IndexVM();
                List<Rezervacija> rezervacije = db.Rezervacija.
                    OrderByDescending(x => x.DatumRezervacije).Where(x => (x.ImePutnika.ToLower() + " " + x.PrezimePutnika.ToLower()).StartsWith(imePrezime.ToLower()) || (x.PrezimePutnika.ToLower() + " " + x.ImePutnika.ToLower()).StartsWith(imePrezime.ToLower())).
                    Include(x => x.Sjediste).
                    Include(x => x.Let).
                    Include(x => x.Let.Grad).
                    Include(x => x.Let.Grad1).
                    Take(60).
                    ToList();

                Model.podaci = rezervacije.Select(x => new Rezervacije_IndexVM.Rows
                {
                    RezervacijaID = x.RezervacijaID,
                    ImePrezime = x.ImePutnika + " " + x.PrezimePutnika,
                    DatumRodjenjaPutnika = x.DatumRodjenjaPutnika.ToString("d MMM, yyyy"),
                    SpolTip = x.Spol + " / " + x.TipPutnika,
                    TipDokumenta = x.TipDokumenta,
                    BrojDokumenta = x.BrojDokumenta,
                    DatumRezervacije = x.DatumRezervacije.ToString("d MMM, yyyy HH:mm"),
                    Sjediste = x.Sjediste.Oznaka,
                    DatumLeta = x.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm"),
                    BrojLeta = x.Let.BrojLeta,
                    RutaPutovanja = x.Let.Grad1.Naziv + " (" + x.Let.Grad1.Oznaka + ") " + x.Let.Grad.Naziv + " (" + x.Let.Grad.Oznaka + ")"

                }).ToList();

                return Ok(Model);
            }
            
        }


            // GET: api/Rezervacija
            public IHttpActionResult GetRezervacija()
        {
            Rezervacije_IndexVM Model = new Rezervacije_IndexVM();
            List<Rezervacija> rezervacije = db.Rezervacija.
                OrderByDescending(x => x.DatumRezervacije).
                Include(x => x.Sjediste).
                Include(x => x.Let).
                Include(x => x.Let.Grad).
                Include(x => x.Let.Grad1).
                Take(60).
                ToList();

            Model.podaci = rezervacije.Select(x => new Rezervacije_IndexVM.Rows
            {
                RezervacijaID = x.RezervacijaID,
                ImePrezime = x.ImePutnika + " " + x.PrezimePutnika,
                DatumRodjenjaPutnika = x.DatumRodjenjaPutnika.ToString("d MMM, yyyy"),
                SpolTip = x.Spol + " / " + x.TipPutnika,
                TipDokumenta = x.TipDokumenta,
                BrojDokumenta = x.BrojDokumenta,
                DatumRezervacije = x.DatumRezervacije.ToString("d MMM, yyyy HH:mm"),
                Sjediste = x.Sjediste.Oznaka,
                DatumLeta = x.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm"),
                BrojLeta = x.Let.BrojLeta,
                RutaPutovanja = x.Let.Grad1.Naziv + " (" + x.Let.Grad1.Oznaka + ") " + x.Let.Grad.Naziv + " (" + x.Let.Grad.Oznaka + ")"

            }).ToList();

            return Ok(Model);
        }

        // GET: api/Rezervacija/5
        [ResponseType(typeof(Rezervacija))]
        public IHttpActionResult GetRezervacija(int id)
        {
            Rezervacija rezervacija = db.Rezervacija.Include(x=>x.Let)
                .Include(x=>x.Sjediste).Include(x=>x.Let.Grad).Include(x => x.Let.Grad1).Include(x=>x.Korisnik)
                .Where(x=>x.RezervacijaID==id).FirstOrDefault();
            if (rezervacija == null)
            {
                return NotFound();
            }

            return Ok(rezervacija);
        }

        // PUT: api/Rezervacija/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRezervacija(int id, Rezervacija rezervacija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rezervacija.RezervacijaID)
            {
                return BadRequest();
            }

            db.Entry(rezervacija).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RezervacijaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Rezervacija
        [ResponseType(typeof(Rezervacija))]
        public IHttpActionResult PostRezervacija(Rezervacija rezervacija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rezervacija.Add(rezervacija);
            db.SaveChanges();

            return Ok(rezervacija.RezervacijaID);
        }

        // DELETE: api/Rezervacija/5
        [ResponseType(typeof(Rezervacija))]
        public IHttpActionResult DeleteRezervacija(int id)
        {
            Rezervacija rezervacija = db.Rezervacija.Find(id);
            if (rezervacija == null)
            {
                return NotFound();
            }

            db.Rezervacija.Remove(rezervacija);
            db.SaveChanges();

            return Ok(rezervacija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RezervacijaExists(int id)
        {
            return db.Rezervacija.Count(e => e.RezervacijaID == id) > 0;
        }
    }
}