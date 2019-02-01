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
    public class ZaposlenikController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/Zaposlenik
        public IHttpActionResult GetZaposlenik()
        {
            Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
            Model.podaci = db.Zaposlenik.Select(x => new Zaposlenici_IndexVM.Rows
            {
                ZaposlenikID = x.ZaposlenikID,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Email = x.Email,
                Telefon = x.Telefon,
                BrojUgovora = x.BrojUgovora,
                Spol = x.Spol,
                DatumRodenja = x.DatumRodenja.ToString(),
                Aktivan = x.Aktivan,
                Pozicija = x.TipZaposlenja.Naziv,
                Grad = x.Grad.Naziv
            }).ToList();

            return Ok(Model);
        }

        [HttpGet]
        [Route("api/Zaposlenik/SearchAllPosada/{parametar?}")]
        [ResponseType(typeof(Zaposlenici_IndexVM))]
        public IHttpActionResult SearchAllPosada(string parametar="")
        {
            Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
            Model.podaci = db.Zaposlenik.Where(x=>x.TipZaposlenjaID!=1).Select(x => new Zaposlenici_IndexVM.Rows
            {
                ZaposlenikID = x.ZaposlenikID,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Email = x.Email,
                Telefon = x.Telefon,
                BrojUgovora = x.BrojUgovora,
                Spol = x.Spol,
                DatumRodenja = x.DatumRodenja.ToString(),
                Aktivan = x.Aktivan,
                Pozicija = x.TipZaposlenja.Naziv,
                Grad = x.Grad.Naziv
            }).ToList();

            return Ok(Model);
        }

        [HttpGet]
        [Route("api/Zaposlenik/SearchByImePrezimePosada/{imePrezime?}")]
        [ResponseType(typeof(Zaposlenici_IndexVM))]
        public IHttpActionResult SearchByImePrezimePosada(string imePrezime = "")
        {
            if (imePrezime == "")
            {
                Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
                Model.podaci = db.Zaposlenik.Where(x => x.TipZaposlenjaID != 1).Select(x => new Zaposlenici_IndexVM.Rows
                {
                    ZaposlenikID = x.ZaposlenikID,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    Email = x.Email,
                    Telefon = x.Telefon,
                    BrojUgovora = x.BrojUgovora,
                    Spol = x.Spol,
                    DatumRodenja = x.DatumRodenja.ToString(),
                    Aktivan = x.Aktivan,
                    Pozicija = x.TipZaposlenja.Naziv,
                    Grad = x.Grad.Naziv
                }).ToList();

                return Ok(Model);
            }
            else
            {
                Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
                Model.podaci = db.Zaposlenik.Where(x => (x.Ime.ToLower() + x.Prezime.ToLower()).StartsWith(imePrezime.Trim().ToLower()) && x.TipZaposlenjaID != 1)
                    .Select(x => new Zaposlenici_IndexVM.Rows
                    {
                        ZaposlenikID = x.ZaposlenikID,
                        Ime = x.Ime,
                        Prezime = x.Prezime,
                        Email = x.Email,
                        Telefon = x.Telefon,
                        BrojUgovora = x.BrojUgovora,
                        Spol = x.Spol,
                        DatumRodenja = x.DatumRodenja.ToString(),
                        Aktivan = x.Aktivan,
                        Pozicija = x.TipZaposlenja.Naziv,
                        Grad = x.Grad.Naziv
                    }).ToList();

                if (Model.podaci.Count == 0)
                {
                    return NotFound();
                }
                return Ok(Model);
            }
        }
        [HttpGet]
        [Route("api/Zaposlenik/SearchByImePrezime/{tipZaposlenja?}/{imePrezime?}")]
        [ResponseType(typeof(Zaposlenici_IndexVM))]
        public IHttpActionResult SearchByImePrezime(string tipZaposlenja = "", string imePrezime = "")
        {
            int tipID = int.Parse(tipZaposlenja);

            if (imePrezime == "")
            {
                if (tipID == 0)
                {
                    Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
                    Model.podaci = db.Zaposlenik.Select(x => new Zaposlenici_IndexVM.Rows
                    {
                        ZaposlenikID = x.ZaposlenikID,
                        Ime = x.Ime,
                        Prezime = x.Prezime,
                        Email = x.Email,
                        Telefon = x.Telefon,
                        BrojUgovora = x.BrojUgovora,
                        Spol = x.Spol,
                        DatumRodenja = x.DatumRodenja.ToString(),
                        Aktivan = x.Aktivan,
                        Pozicija = x.TipZaposlenja.Naziv,
                        Grad = x.Grad.Naziv
                    }).ToList();

                    if (Model.podaci.Count == 0)
                    {
                        return NotFound();
                    }

                    return Ok(Model);
                }
                else
                {
                    Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
                    Model.podaci = db.Zaposlenik.Where(x=>x.TipZaposlenjaID==tipID).Select(x => new Zaposlenici_IndexVM.Rows
                    {
                        ZaposlenikID = x.ZaposlenikID,
                        Ime = x.Ime,
                        Prezime = x.Prezime,
                        Email = x.Email,
                        Telefon = x.Telefon,
                        BrojUgovora = x.BrojUgovora,
                        Spol = x.Spol,
                        DatumRodenja = x.DatumRodenja.ToString(),
                        Aktivan = x.Aktivan,
                        Pozicija = x.TipZaposlenja.Naziv,
                        Grad = x.Grad.Naziv
                    }).ToList();

                    if (Model.podaci.Count == 0)
                    {
                        return NotFound();
                    }

                    return Ok(Model);
                }
                
            }
            else
            {
                if (tipID == 0)
                {
                    Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
                    Model.podaci = db.Zaposlenik.Where(x => (x.Ime.ToLower() + x.Prezime.ToLower()).StartsWith(imePrezime.Trim().ToLower()))
                        .Select(x => new Zaposlenici_IndexVM.Rows
                        {
                            ZaposlenikID = x.ZaposlenikID,
                            Ime = x.Ime,
                            Prezime = x.Prezime,
                            Email = x.Email,
                            Telefon = x.Telefon,
                            BrojUgovora = x.BrojUgovora,
                            Spol = x.Spol,
                            DatumRodenja = x.DatumRodenja.ToString(),
                            Aktivan = x.Aktivan,
                            Pozicija = x.TipZaposlenja.Naziv,
                            Grad = x.Grad.Naziv
                        }).ToList();

                    if (Model.podaci.Count == 0)
                    {
                        return NotFound();
                    }

                    return Ok(Model);
                }
                else
                {
                    Zaposlenici_IndexVM Model = new Zaposlenici_IndexVM();
                    Model.podaci = db.Zaposlenik.Where(x =>x.TipZaposlenjaID==tipID && (x.Ime.ToLower() + x.Prezime.ToLower()).StartsWith(imePrezime.Trim().ToLower()))
                        .Select(x => new Zaposlenici_IndexVM.Rows
                        {
                            ZaposlenikID = x.ZaposlenikID,
                            Ime = x.Ime,
                            Prezime = x.Prezime,
                            Email = x.Email,
                            Telefon = x.Telefon,
                            BrojUgovora = x.BrojUgovora,
                            Spol = x.Spol,
                            DatumRodenja = x.DatumRodenja.ToString(),
                            Aktivan = x.Aktivan,
                            Pozicija = x.TipZaposlenja.Naziv,
                            Grad = x.Grad.Naziv
                        }).ToList();

                    if (Model.podaci.Count == 0)
                    {
                        return NotFound();
                    }

                    return Ok(Model);
                }
                
            }
        }




        [HttpGet]
        [Route("api/Zaposlenik/GetSearchByEmail/{email}/{id}")]
        public IHttpActionResult GetSearchByEmail(string email, int id)
        {
            Zaposlenik zaposlenik = db.Zaposlenik.Where(x => x.Email == email && x.ZaposlenikID != id).FirstOrDefault();
            if (zaposlenik == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet]
        [Route("api/Zaposlenik/SearchByTelefon/{telefon}/{id}")]
        public IHttpActionResult SearchByTelefon(string telefon, int id)
        {
            Zaposlenik zaposlenik = db.Zaposlenik.Where(x => x.Telefon.Substring(1) == telefon && x.ZaposlenikID != id).FirstOrDefault();
            if (zaposlenik == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet]
        [Route("api/Zaposlenik/GetZaposlenikByID/{id}")]
        [ResponseType(typeof(Zaposlenik))]
        public IHttpActionResult GetZaposlenikByID(int id)
        {
            Zaposlenik zaposlenik = db.Zaposlenik.Where(x => x.ZaposlenikID == id).Include(x => x.TipZaposlenja).Include(x => x.Grad).Include(x => x.KorisnickiNalog)
                .FirstOrDefault();
            if (zaposlenik == null)
            {
                return NotFound();
            }
            return Ok(zaposlenik);

        }


        // GET: api/Zaposlenik/5
        [ResponseType(typeof(Zaposlenik))]
        public IHttpActionResult GetZaposlenik(int id)
        {
            Zaposlenik zaposlenik = db.Zaposlenik.Where(x=>x.ZaposlenikID==id).Include(x=>x.TipZaposlenja).Include(x => x.Grad)
                .FirstOrDefault();
            if (zaposlenik == null)
            {
                return NotFound();
            }
            Zaposlenici_IndexVM.Rows z = new Zaposlenici_IndexVM.Rows();
            z.Aktivan = zaposlenik.Aktivan;
            z.BrojUgovora = zaposlenik.BrojUgovora;
            z.Email = zaposlenik.Email;
            z.Ime= zaposlenik.Ime;
            z.Prezime= zaposlenik.Prezime;
            z.Spol= zaposlenik.Spol;
            z.Telefon= zaposlenik.Telefon;
            z.ZaposlenikID= zaposlenik.ZaposlenikID;
            z.Pozicija = zaposlenik.TipZaposlenja.Naziv;
            z.Grad = zaposlenik.Grad.Naziv;
            z.DatumRodenja = zaposlenik.DatumRodenja.ToShortDateString();
            return Ok(z);
        }

        // PUT: api/Zaposlenik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZaposlenik(int id, Zaposlenik zaposlenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zaposlenik.ZaposlenikID)
            {
                return BadRequest();
            }

            Zaposlenik z = db.Zaposlenik.Find(id);
            z.ZaposlenikID = zaposlenik.ZaposlenikID;
            z.Aktivan = zaposlenik.Aktivan;
            z.BrojUgovora = zaposlenik.BrojUgovora;
            z.DatumRodenja = zaposlenik.DatumRodenja;
            z.Email = zaposlenik.Email;
            z.GradID = zaposlenik.GradID;
            z.Ime = zaposlenik.Ime;
            z.Prezime = zaposlenik.Prezime;
            z.Spol = zaposlenik.Spol;
            z.Telefon = zaposlenik.Telefon;
            z.TipZaposlenjaID = zaposlenik.TipZaposlenjaID;

            db.SaveChanges();


            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Zaposlenik
        [ResponseType(typeof(Zaposlenik))]
        public IHttpActionResult PostZaposlenik(Zaposlenik zaposlenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zaposlenik.Add(zaposlenik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zaposlenik.ZaposlenikID }, zaposlenik);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
       
    }
